using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using System.Data.SqlClient;
using System.Configuration;
namespace AnimalHouseDB
{
    public class AnimalHouseEmailDB : IEmail
    {
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        public AnimalHouseEmailDB()
        {
        }

        public List<Email> HentEmail(int id)
        {
            using (conn)
            {
                SqlTransaction transaction = null;
                List<Email> el = null;
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Email where EmailId = @EmailId", conn);
                    command.Parameters.Add(new SqlParameter("@emailId", id));
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    el = new List<Email>();
                    while (reader.Read())
                    {
                         Email e = new Email();
                        e.EmailId = Convert.ToInt32(reader["EmailId"]);
                        e.DyrId = Convert.ToInt32(reader["KundeId"]);
                        e.Title = Convert.ToString(reader["Title"]);
                        e.Indhold = Convert.ToString(reader["Indhold"]);
                        e.Dato = Convert.ToDateTime(reader["Dato"]);
                        el.Add(e);
                    }
                    reader.Close();

                }
                catch (Exception HentEmailError)
                {
                    throw HentEmailError;
                }
                finally
                {
                    conn.Close();

                }
                return el;
            }
        }

        public List<Email> HentEmails()
        {
            using (conn)
            {
                SqlTransaction transaction = null;
                List<Email> el = null;
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Email", conn);
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    el = new List<Email>();
                    while (reader.Read())
                    {
                        Email e = new Email();
                        e.EmailId = Convert.ToInt32(reader["EmailId"]);
                        e.DyrId = Convert.ToInt32(reader["KundeId"]);
                        e.Title = Convert.ToString(reader["Title"]);
                        e.Indhold = Convert.ToString(reader["Indhold"]);
                        el.Add(e);
                    }
                    reader.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();

                }
                return el;
            }
        }

        public List<Email> HentEmailsByKunde(int id)
        {
            using (conn)
            {
                SqlTransaction transaction = null;
                List <Email> el = null;
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Email Join Kunde on Email.KundeId = Kunde.KundeId where KundeId = @KundeId", conn);
                    command.Parameters.Add(new SqlParameter("@KundeId", id));
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    el = new List<Email>();
                    while (reader.Read())
                    {
                        Email e = new Email();
                        e.EmailId = Convert.ToInt32(reader["EmailId"]);
                        e.DyrId = Convert.ToInt32(reader["KundeId"]);
                        e.Title = Convert.ToString(reader["Title"]);
                        e.Indhold = Convert.ToString(reader["Indhold"]);
                        el.Add(e);
                    }
                    reader.Close();
                    
                }
                catch (Exception e)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    throw e;
                }
                finally
                {
                    conn.Close();
                    
                }
                return el;
            }
        }

        public bool InsertMail(Email E)
        {
            using (conn)
            {
                conn.Open();
                try
                {
                    string commandtxt = $"Insert into Email (DyrId, title, Indhold) values (@DyrId, @Title, @Indhold)";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    command.Parameters.Add(new SqlParameter("@DyrId", E.DyrId));
                    command.Parameters.Add(new SqlParameter("@Title", E.Title));
                    command.Parameters.Add(new SqlParameter("@Indhold", E.Indhold));

                    command.ExecuteNonQuery();
                }
                catch (Exception InsertEmailError)
                {
                    throw InsertEmailError;
                }
                finally
                {
                    conn.Close();
                }

                return true;
            }
        }
    }
}
