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
    public class AnimalhouseDyrDatabase: IDyrDB
    {
        

        public AnimalhouseDyrDatabase()
        {
        }

        public List<Dyr> HentAlleDyr()
        {
            List<Dyr> ld = null;
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Dyr", conn);
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    ld = new List<Dyr>();
                    while (reader.Read())
                    {
                        Dyr d = new Dyr();
                        d.DyrId = Convert.ToInt32(reader["DyrId"]);
                        d.KundeId = Convert.ToInt32(reader["KundeId"]);
                        d.Race = Convert.ToString(reader["Race"]);
                        d.Art = Convert.ToString(reader["Art"]);
                        d.Alder = Convert.ToInt32(reader["Alder"]);
                        d.Sex = Convert.ToChar(reader["Sex"]);
                      
                        ld.Add(d);
                    }
                    reader.Close();
                    return ld;
                }
                catch(Exception e)
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
        public Dyr HentDyr(int Id)
        {
            Dyr d = null;
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Dyr", conn);
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    d = new Dyr();
                    if (reader.Read())
                    {

                        d.DyrId = Convert.ToInt32(reader["DyrID"]);
                        d.KundeId = Convert.ToInt32(reader["KundeId"]);
                        d.Race = Convert.ToString(reader["Race"]);
                        d.Art = Convert.ToString(reader["Art"]);
                        d.Alder = Convert.ToInt32(reader["Alder"]);
                        d.Sex = Convert.ToChar(reader["Sex"]);
                        reader.Close();
                    }
                    
                }
                catch (Exception)
                {
                   
                    return d;
                }
                finally
                {
                    conn.Close();
                }
            }
            return d;
        }

        public string OpretDyr(Dyr d)
        {
            string result;
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Dyr (KundeId, Art, Race, Alder, sex) values (@KundeId, @Art, @Race, @Alder, @sex)", conn);
                    command.Parameters.Add(new SqlParameter("@KundeId", d.KundeId));
                    command.Parameters.Add(new SqlParameter("@Art", d.Art));
                    command.Parameters.Add(new SqlParameter("@Race", d.Race));
                    command.Parameters.Add(new SqlParameter("@Alder", d.Alder));
                    command.Parameters.Add(new SqlParameter("@sex", d.Sex));
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    result = "Dyret er tilføjet";
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

        public string SletDyr(int Id)
        {
            string result;
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("DELETE Dyr WHERE DyrId = @DyrId", conn);
                    command.Parameters.Add(new SqlParameter("@DyrId", Id));
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    result = "Dyret er Slettet";
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

        public string UpdaterDyr(Dyr d)
        {
            
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("Update Dyr SET KundeId = @KundeId, Art = @Art, Race= @Race, Alder = @Alder, sex = @sex where DyrId = @DyrId", conn);
                    command.Parameters.Add(new SqlParameter("@DyrId", d.DyrId));
                    command.Parameters.Add(new SqlParameter("@KundeId", d.KundeId));
                    command.Parameters.Add(new SqlParameter("@Art", d.Art));
                    command.Parameters.Add(new SqlParameter("@Race", d.Race));
                    command.Parameters.Add(new SqlParameter("@Alder", d.Alder));
                    command.Parameters.Add(new SqlParameter("@Race", d.Race));
                    command.Parameters.Add(new SqlParameter("@sex", d.Sex));
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    return "Dyret er Updateret";
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

        public List<Dyr> HentDyrByKundeId(int KId)
        {
            List<Dyr> ld = null;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Dyr WHERE KundeId = @KundeId", conn);
                    command.Parameters.Add(new SqlParameter("@KundeId", KId));
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    ld = new List<Dyr>();
                while (reader.Read())
                {
                    Dyr d = new Dyr();
                    d.DyrId = Convert.ToInt32(reader["DyrId"]);
                    d.KundeId = Convert.ToInt32(reader["KundeId"]);
                    d.Race = Convert.ToString(reader["Race"]);
                    d.Art = Convert.ToString(reader["Art"]);
                    d.Alder = Convert.ToInt32(reader["Alder"]);
                    d.Sex = Convert.ToChar(reader["Sex"]);   
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


        //holger;
        public List<Dyr> HentDyrDerSkalHaveEmail(int mailDage, int visitDage)
        {
            List<Dyr> ld = null;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {

                //ændre til negativ værdig
                mailDage = mailDage * -1;
                visitDage = visitDage * -1;

                //outer joiner to views
                SqlCommand command = new SqlCommand("select LastVisit.DyrId from LastVisit " +
                    "full outer join LastMail on LastVisit.DyrId = LastMail.DyrId " +
                    "where (LastVisit.DyrId is null or LastMail.DyrId is null) " +
                    //sætter tre begrænsning på hvor tidlig mail skaL sendes ud
                    "where ((LastVisit.DyrId is null or LastMail.DyrId is null) " +
                    //sætter To begrænsning på hvor tidlig mail skaL sendes ud
                    //en for hvornår de der været sidste på besøg får email
                    //en for hvornår de der sidste har fået email (ingen grund til at sende mail ud hver dag)
                    //en for hvis det er længe sidden de har været på besøg og aldrig har fået mail.
                    "and (LastVisit.created_at < DATEADD(DAY, @mailDage, GETDATE()) " +
                    "and LastMail.created_at < DATEADD(DAY, @visitDage, GETDATE()) " +
                    "or ((LastVisit.DyrId is null or LastMail.DyrId is null) " +
                    "and LastVisit.created_at < DATEADD(DAY, visitDage, GETDATE()) " +
                    "and LastMail.DyrId is null)", conn);
                command.Parameters.Add(new SqlParameter("@mailDage", mailDage));
                command.Parameters.Add(new SqlParameter("@visitDage", visitDage));
                command.Transaction = transaction;
                SqlDataReader reader = command.ExecuteReader();
                ld = new List<Dyr>();
                while (reader.Read())
                {
                    Dyr d = new Dyr();
                    d.DyrId = Convert.ToInt32(reader["DyrId"]);
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
}
