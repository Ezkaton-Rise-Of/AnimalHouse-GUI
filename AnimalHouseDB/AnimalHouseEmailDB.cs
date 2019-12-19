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
    //Holger
    public class AnimalHouseEmailDB : IEmail
    {

        public AnimalHouseEmailDB()
        {
        }

        public List<Email> HentEmail(int id)
        {
           
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
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
                    transaction.Commit();

                }
                catch (Exception HentEmailError)
                {
                    transaction.Rollback();
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
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
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
                return el;
            }
        }

        public List<Email> HentEmailsByKunde(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
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
                return el;
            }
        }

        public List<Dyr> HentKunderDerManglerMail(int mailDage = 365, int visitDage = 365)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                SqlTransaction transaction = null;
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {

                    //ændre til negativ værdig
                    mailDage = mailDage * -1;
                    visitDage = visitDage * -1;

                    //outer joiner to views
                    SqlCommand command = new SqlCommand("select Dyr.KundeId, LastVisit.DyrId, lastvisit.created_at " +
                        "from LastVisit " +
                        "left join Dyr on Dyr.DyrId = LastVisit.DyrId " +
                        "full outer join LastMail on LastVisit.DyrId = LastMail.DyrId " +
                        "where(LastVisit.DyrId is null or LastMail.DyrId is null) " +
                        "and (LastVisit.created_at < DATEADD(DAY, @visitDage, GETDATE()) " +
                        "and LastMail.created_at < DATEADD(DAY, @mailDage, GETDATE())) " +
                        "or ((LastVisit.DyrId is null or LastMail.DyrId is null) " +
                        "and LastVisit.created_at < DATEADD(DAY, @visitDage, GETDATE()) " +
                        "and LastMail.DyrId is null)", conn);
                    command.Parameters.Add(new SqlParameter("@mailDage", mailDage));
                    command.Parameters.Add(new SqlParameter("@visitDage", visitDage));
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    List<Dyr> ld = new List<Dyr>();
                    while (reader.Read())
                    {
                        Dyr d = new Dyr();
                        d.DyrId = Convert.ToInt32(reader["DyrId"]);
                        d.KundeId = Convert.ToInt32(reader["KundeId"]);
                        ld.Add(d);
                    }

                    reader.Close();
                    return ld;
                }
                catch (Exception e)
                {
                    throw e;

                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public bool InsertMail(Email E)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
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
