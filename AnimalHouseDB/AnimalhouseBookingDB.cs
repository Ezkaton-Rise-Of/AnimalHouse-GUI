﻿//Holger
using AnimalHouse_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
namespace AnimalHouseDB
{
    public class AnimalhouseBookingDB : IBookingDB
    {
        public AnimalhouseBookingDB()
        {
        }
        public List<Booking> HentAlleBooking(Kunde k)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                List<Booking> ld = null;
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    SqlCommand command = new SqlCommand("SELECT Booking.ProduKtId, Booking.BookingId, Booking.Startdato, Booking.Slutdato, Booking.Notat, Produkt.Navn, s.TimeRange as start, e.TimeRange as slut " +
                        "FROM Booking left join Produkt on Produkt.ProduktId = Booking.ProduKtId " +
                        "left join BookingTimer as s on Booking.StartTid = s.BookingTimerId " +
                        "left join BookingTimer as e on Booking.SlutTid = e.BookingTimerId " +
                        "inner join Dyr on Dyr.DyrId = Booking.DyrId " +
                        "inner join Kunde on Kunde.KundeId = dyr.KundeId where Kunde.KundeId = @Kunde", conn);
                    command.Parameters.Add(new SqlParameter("@Kunde", k.Id));

                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    ld = new List<Booking>();
                    while (reader.Read())
                    {
                        Booking d = new Booking();
                        d.BookingId = Convert.ToInt32(reader["BookingId"]);
                        d.Notat = Convert.ToString(reader["Notat"]);
                        d.StartDato = Convert.ToDateTime(reader["Startdato"]);
                        d.SlutDato = Convert.ToDateTime(reader["Slutdato"]);
                        Service s = new Service();
                        s.Navn = Convert.ToString(reader["Navn"]);
                        s.ProduktId = Convert.ToInt32(reader["ProduKtId"]);
                        d.service = s;
                        BookingTime start = new BookingTime();
                        start.time = Convert.ToString(reader["start"]);
                        d.startTid = start;
                        BookingTime slut = new BookingTime();
                        slut.time = Convert.ToString(reader["slut"]);
                        d.slutTid = slut;
                        ld.Add(d);
                    }
                    reader.Close();
                    transaction.Commit();

                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw e;
                }
                finally
                {
                    conn.Close();
                }

                return ld;
            }
        }
        public List<BookingTime> HentAlleFritider(Ansat ansat, DateTime dateTime, Servicetype servicetype)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                List<BookingTime> bookingTimes = null;
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    SqlCommand command;
                    // hvis der skal laves operation findes der både tider hvor både lægen og operationsrummet er ledig;
                    if (servicetype.ServiceType == "Operation")
                    {
                        command = new SqlCommand("select * from BookingTimer " +
                            "where NOT EXISTS(select '' from Booking left join Service on Service.ProduktId = Booking.ProduKtId " +
                            "where (BookingTimer.BookingTimerId >= Booking.StartTid " +
                            "and BookingTimer.BookingTimerId < Booking.SlutTid " +
                            "and Booking.Startdato = @dato " +
                            "and Service.ServiceTypeId = 2) " +
                            "or (BookingTimer.BookingTimerId >= Booking.StartTid " +
                            "and BookingTimer.BookingTimerId < Booking.SlutTid " +
                            "and Booking.Startdato = @dato AND Booking.AnsatId = @AnsatId));", conn);
                    }
                    else
                    {

                    //eller findes der tid hvor lægen er fri
                        command = new SqlCommand("select * from BookingTimer " +
                            "where NOT EXISTS(select '' from Booking where BookingTimer.BookingTimerId >= Booking.StartTid " +
                            "and BookingTimer.BookingTimerId < Booking.SlutTid " +
                            "and Booking.Startdato = @dato AND Booking.AnsatId = @AnsatId);", conn);
                    }
                    command.Parameters.Add(new SqlParameter("@dato", dateTime.ToString("yyyy-MM-dd")));
                    command.Parameters.Add(new SqlParameter("@AnsatId", ansat.Id));

                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    bookingTimes = new List<BookingTime>();
                    while (reader.Read())
                    {
                        BookingTime d = new BookingTime();
                        d.timeId = Convert.ToInt32(reader["BookingTimerId"]);
                        d.time = Convert.ToString(reader["TimeRange"]);
                        bookingTimes.Add(d);
                    }
                    reader.Close();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw e;
                }
                finally
                {
                    conn.Close();
                }

                return bookingTimes;
            }
        }
        public List<BookingTime> HentAlleHentMuligeSlutTider(Ansat ansat, BookingTime startTid, DateTime dateTime, Servicetype serviceType)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                List<BookingTime> bookingTimes = null;
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    SqlCommand command;
                    if (serviceType.ServiceType == "Operation")
                    {
                        command = new SqlCommand("" +
                            //hvis lægen eller operationsrummet har en booking efter den givne starttid
                            "if 0 < (select Count(*) from Booking " +
                            "left join Service on Service.ProduktId = Booking.ProduKtId where Booking.Startdato = @Dato " +
                            "and Booking.StartTid > @starttime AND (Service.ServiceTypeId = 2 or Booking.AnsatId = @Ansat)) " +
                            //hvis lægen har en booking efter starttid hentes tiderne hvor operationsrummet og lægen er ledig til en af dem er optaget igen;
                            "if 0 < (select Count(*) from Booking " +
                            "where Booking.Startdato = @Dato AND AnsatId = @Ansat) " +
                            "select * from BookingTimer " +
                            "where BookingTimer.BookingTimerId " +
                            "between @starttime and(select top 1 Booking.StartTid from Booking " +
                            "left join Service on Service.ProduktId = Booking.ProduKtId " +
                            "where Booking.Startdato = @Dato and Booking.StartTid > @starttime " +
                            "AND (Service.ServiceTypeId = 2 or Booking.AnsatId = @Ansat) " +
                            "order by Booking.StartTid  asc) " +
                            // eller hentes tiderne indtil operationsrummet er optaget
                            "else select* from BookingTimer where BookingTimer.BookingTimerId " +
                            "between 8 and (select top 1 Booking.StartTid from Booking " +
                            "left join Service on Service.ProduktId = Booking.ProduKtId " +
                            "where Booking.StartTid > @starttime and Booking.Startdato = @Dato " +
                            "AND Service.ServiceTypeId = 2 order by Booking.StartTid  asc) " +
                            // har ingen af dem bookinger den dan hentet alle tider efter starttiden;
                            "else select* from BookingTimer where BookingTimer.BookingTimerId > @starttime", conn);
                    }
                    else
                    {
                        //
                        command = new SqlCommand("if 1 < (select Count(*) from Booking " +
                       "where Booking.StartTid > @starttime AND Booking.Startdato = @Dato AND ansatID = @Ansat) " +
                       "select * from BookingTimer " +
                       "where BookingTimer.BookingTimerId " +
                       "between @starttime " +
                       "and(select top 1 Booking.StartTid " +
                       "from Booking where Booking.StartTid > @starttime " +
                       "and Booking.Startdato = @Dato AND " +
                       "ansatID = @Ansat order by Booking.StartTid  asc) " +
                       "else select* from BookingTimer where BookingTimer.BookingTimerId > @starttime", conn);
                    }


                    command.Parameters.Add(new SqlParameter("@Ansat", ansat.Id));
                    command.Parameters.Add(new SqlParameter("@starttime", startTid.timeId));
                    command.Parameters.Add(new SqlParameter("@Dato", dateTime.ToString("yyyy-MM-dd")));

                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    bookingTimes = new List<BookingTime>();
                    while (reader.Read())
                    {
                        BookingTime d = new BookingTime();
                        d.timeId = Convert.ToInt32(reader["BookingTimerId"]);
                        d.time = Convert.ToString(reader["TimeRange"]);
                        bookingTimes.Add(d);
                    }
                    reader.Close();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();

                    throw e;
                }
                finally
                {
                    conn.Close();
                }

                return bookingTimes;
            }
        }
        public Booking HentBooking(int Id)

        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                Booking d = null;
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    SqlCommand command = new SqlCommand("SELECT * FROM Booking Where BookingId = " + Id);
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        d = new Booking();
                        d.BookingId = Convert.ToInt32(reader["BookingId"]);
                        d.DyrId = Convert.ToInt32(reader["DyrId"]);
                        d.AnsatId = Convert.ToInt32(reader["AnsatId"]);
                        d.Notat = Convert.ToString(reader["Notat"]);
                        d.StartDato = Convert.ToDateTime(reader["StartDato"]);
                        d.SlutDato = Convert.ToDateTime(reader["SlutDato"]);
                    }
                    reader.Close();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw e;
                }
                finally
                {
                    conn.Close();
                }
                return d;
            }
        }
 
        public bool OpretBooking(Booking b)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                bool answer = false;
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    SqlCommand command = new SqlCommand("Insert into Booking (DyrId, AnsatId, Notat, StartDato, SlutDato, startTid, slutTid, ProduKtId) values (@DyrId,  @AnsatId,  @Notat, @StartDato, @SlutDato, @StartTid, @SlutTid, @ProduktId)", conn);
                    command.Parameters.Add(new SqlParameter("@DyrId", b.DyrId));
                    command.Parameters.Add(new SqlParameter("@AnsatId", b.AnsatId));
                    command.Parameters.Add(new SqlParameter("@Notat", b.Notat));
                    command.Parameters.Add(new SqlParameter("@StartDato", b.StartDato.ToString("yyyy-MM-dd")));
                    command.Parameters.Add(new SqlParameter("@SlutDato", b.SlutDato.ToString("yyyy-MM-dd")));
                    command.Parameters.Add(new SqlParameter("@StartTid", b.startTid.timeId));
                    command.Parameters.Add(new SqlParameter("@Sluttid", b.slutTid.timeId));
                    command.Parameters.Add(new SqlParameter("@ProduktId", b.service.ProduktId));
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    answer = true;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw e;

                }
                finally
                {
                    conn.Close();
                }
                return answer;
            }
        }
        public bool OpretbookingBur(string text, Dyr dyr, DateTime start, DateTime slut, Bur bur)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                bool answer = false;
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    SqlCommand command1 = new SqlCommand("Insert into Booking (DyrId, Notat, StartDato, SlutDato, ProduKtId) values (@DyrId,  @Notat, @StartDato, @SlutDato, 1); SELECT CAST(scope_identity() AS int)", conn, transaction);
                    command1.Parameters.Add(new SqlParameter("@DyrId", dyr.DyrId));
                    command1.Parameters.Add(new SqlParameter("@Notat", text));
                    command1.Parameters.Add(new SqlParameter("@StartDato", start.ToString("yyyy-MM-dd")));
                    command1.Parameters.Add(new SqlParameter("@SlutDato", slut.ToString("yyyy-MM-dd")));
                    Int32 id = (Int32)command1.ExecuteScalar();
                    SqlCommand command2 = new SqlCommand($"Insert into Booking_Has_bur (BookingId, BurId) values ({id} , @bur)", conn, transaction);
                    command2.Parameters.Add(new SqlParameter("@bur", bur.Id));
                    command2.ExecuteNonQuery();
                    transaction.Commit();
                    answer = true;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw e;

                }
                finally
                {
                    conn.Close();
                }
                return answer;
            }
        }
        public bool SletBooking(Booking b)

        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                bool result = false;
                SqlTransaction transaction = null;

                    try
                    {
                        conn.Open();
                        transaction = conn.BeginTransaction();
                    
                    if (b.service.ProduktId == 1)
                    {
                        SqlCommand command1 = new SqlCommand("DELETE Booking_Has_Bur where BookingId = @BookingId", conn);
                        command1.Parameters.Add(new SqlParameter("@BookingId", b.BookingId));
                        command1.Transaction = transaction;
                        command1.ExecuteNonQuery();
                    }
                    SqlCommand command = new SqlCommand("DELETE Booking WHERE BookingId = @BookingId", conn);
                        command.Parameters.Add(new SqlParameter("@BookingId", b.BookingId));
                        command.Transaction = transaction;
                        command.ExecuteNonQuery();
                        transaction.Commit();
                        result = true;
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        throw e;
                    }
                    finally
                    {
                        conn.Close();
                    }
                return result;
            }
        }
        public bool UpdaterBooking(Booking b)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                bool answer = false;
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    SqlCommand command = new SqlCommand("Update Booking SET DyrId = @DyrId, AnsatId = @AnsatId, Notat= @Notat, StartDato = @StartDato, SlutDato = @SlutDato where BookingId = @BookingId");
                    command.Parameters.Add(new SqlParameter("@BookingId", b.BookingId));
                    command.Parameters.Add(new SqlParameter("@DyrId", b.DyrId));
                    command.Parameters.Add(new SqlParameter("@AnsatId", b.AnsatId));
                    command.Parameters.Add(new SqlParameter("@Notat", b.Notat));
                    command.Parameters.Add(new SqlParameter("@StartDato", b.StartDato));
                    command.Parameters.Add(new SqlParameter("@SlutDato", b.SlutDato));
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    answer = true;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw e;
                }
                finally
                {
                    conn.Close();
                }
                return answer;
            }
        }
        public List<Booking> HentDyrByKunde(int Id)

        {

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                List<Booking> ld = null;
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    SqlCommand command = new SqlCommand("SELECT * FROM Booking");
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    ld = new List<Booking>();
                    while (reader.Read())
                    {
                        Booking d = new Booking();
                        d.BookingId = Convert.ToInt32(reader["BookingId"]);
                        d.DyrId = Convert.ToInt32(reader["DyrId"]);
                        d.AnsatId = Convert.ToInt32(reader["AnsatId"]);
                        d.Notat = Convert.ToString(reader["Notat"]);
                        d.StartDato = Convert.ToDateTime(reader["StartDato"]);
                        d.SlutDato = Convert.ToDateTime(reader["SlutDato"]);

                        ld.Add(d);
                    }
                    reader.Close();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw e;
                }
                finally
                {

                    conn.Close();
                }
                return ld;
            }
        }

    }
}

