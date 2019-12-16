using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using AnimalHouse_Entities;

namespace AnimalHouseDB
{
    public class AnimalHouseBurDatabase: IBookingBurDB
    {
        public AnimalHouseBurDatabase()
        {
        }



        //Opretter information af Bure
        public string OpretBur(Bur b)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    string commandtxt = $"Insert into Bur (art) values (@art)";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    command.Parameters.Add(new SqlParameter("@Art", b.Art));

                    command.ExecuteNonQuery();
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
            return "Bur Booket";
        }
        //Update information af Bure
        public string UpdateBur (Bur b)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand command = new SqlCommand("Update Bur Set = @art, b.art");
                    command.Parameters.Add(new SqlParameter("@art", b.Art ));

                    command.ExecuteNonQuery();
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
            return "Bur Opdateret";
        }
        //Sletter information af Bure
        public string SletBur (int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    string commandtxt = $"Delete from Bure where BurId = {id}";
                    SqlCommand command = new SqlCommand(commandtxt, conn);

                    command.ExecuteNonQuery();
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
            return "Bur Slettet";
        }

        //Søg efter Bure
        public Bur HentBurByID (int id)
        {
            Bur b = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    string commandtxt = $"Select * from Bur where Id like '{id}'";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        b.Id = (int)reader["BurID"];
                    }
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
            return b;
        }

        public List<Bur> HentAlleBure()
        {
            Bur b = null;
            List<Bur> results = null;
            using(SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    string commandtxt = $"Select * from Bur " + $"join Id";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    results = new List<Bur>();
                    while (reader.Read())
                    {
                        b.Id = (int)reader["BurId"];
                        results.Add(b);
                    }
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
            return results;
        }
        // Holger 
        public List<Bur> HentFribure(DateTime startdato, DateTime slutdato) { 

            List<Bur> results = null;
            SqlTransaction transaction;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {

                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("select * from Bur " +
                        "where not exists(select '' from Booking " +
                        "inner join Booking_Has_Bur " +
                        "on Booking.BookingId = Booking_Has_Bur.BookingId " +
                        "where @startdato <= Booking.Startdato " +
                        "and @slutdato >= Booking.Slutdato and Bur.BurId = Booking_Has_Bur.BurId)", conn);
                    command.Parameters.Add(new SqlParameter("@startdato", startdato.ToString()));
                    command.Parameters.Add(new SqlParameter("@slutdato", slutdato.ToString()));
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    results = new List<Bur>();
                    while (reader.Read())
                    {
                        Bur b = new Bur();
                        b.Id = (int)reader["BurId"];
                        b.Art = (string)reader["Art"];
                        results.Add(b);
                    }
                    reader.Close();
                    transaction.Commit();
                }
                catch (Exception ErrorHentFriBure)
                {
                    transaction.Rollback();
                    throw ErrorHentFriBure;
                }
                finally
                {   
                    conn.Close();
                }
            }
            return results;
        }



    }
}
