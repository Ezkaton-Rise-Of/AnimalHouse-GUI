using AnimalHouse_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace AnimalHouseDB
{
    public class AnimalhouseBookingDB : IBookingDB
    {
        public List<Booking> HentAlleBooking()
        {
            List<Booking> ld = null;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {
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
                return ld;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return ld;
        }

        public Booking HentBooking(int Id)
        {
            Booking d = null;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {
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
                return d;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return d;
        }

        public List<Booking> HentBookingByKunde(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Booking> HentDyrByKunde(int Id)
        {
            List<Booking> ld = null;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {
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
                return ld;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                transaction.Commit();
                conn.Close();
            }

            return ld;
        }

        public bool OpretBooking(Booking b)
        {
            bool answer = false;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand("Insert into Booking (DyrId, AnsatId, Notat, StartDato, SlutDato) values (@DyrId,  @AnsatId,  @Notat, @StartDato, @SlutDato)");
                command.Parameters.Add(new SqlParameter("@BookingId", b.BookingId));
                command.Parameters.Add(new SqlParameter("@DyrId", b.DyrId));
                command.Parameters.Add(new SqlParameter("@AnsatId", b.AnsatId));
                command.Parameters.Add(new SqlParameter("@Notat", b.Notat));
                command.Parameters.Add(new SqlParameter("@StartDato", b.StartDato));
                command.Parameters.Add(new SqlParameter("@SlutDato", b.SlutDato));
                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
                answer= true;
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


        public bool SletBooking(int id)
        {
            bool result = false ;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand("DELETE Booking WHERE BookingId = @BookingId");
                command.Parameters.Add(new SqlParameter("@BookingId", id));
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

        public bool UpdaterBooking(Booking b)
        {
            bool answer = false;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {
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
}

