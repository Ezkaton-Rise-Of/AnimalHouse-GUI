using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using AnimalHouse_Entities;
using AnimalHouse_Entites;
namespace AnimalHouseDB
{
    public class AnimalhouseBookingDB : IBookingDB
    {

        public List<Booking> HentAlleBooking()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";

            List<Booking> ld = null;
            SqlTransaction transaction = null;
            using (conn)
            {
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
            }
            return ld;
        }

        public Booking HentBooking(int Id)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            Booking d = null;
            SqlTransaction transaction = null;
            using (conn)
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Booking Where BookingId = "+Id);
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
            }
            return d;
        }

        public List<Booking> HentBookingByKunde(int Id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            throw new NotImplementedException();
        }

        public List<Booking> HentDyrByKunde(int Id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            List<Booking> ld = null;
            SqlTransaction transaction = null;
            using (conn)
            {
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
            }
            return ld;
        }

        public string OpretBooking(Booking b)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            SqlTransaction transaction = null;
            using (conn)
            {
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
                    return "Booking er oprettet";
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return Convert.ToString(e);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public string SletBooking(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            string result;
            SqlTransaction transaction = null;
            using (conn)
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("DELETE Booking WHERE BookingId = @BookingId");
                    command.Parameters.Add(new SqlParameter("@BookingId", id));
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    result = "Booking er Slettet";
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return Convert.ToString(e);
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }

        public string UpdaterBooking(Booking b)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            SqlTransaction transaction = null;
            using (conn)
            {
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
                    return "Booking er Updateret";
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return Convert.ToString(e);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
