using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using AnimalHouse_Entities;
using AnimalHouse_Entites;

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
                    SqlCommand command = new SqlCommand("SELECT * FROM Dyr");
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    ld = new List<Dyr>();
                    while (reader.Read())
                    {
                        Dyr d = new Dyr();
                        d.DyrId = Convert.ToInt32(reader["DyrID"]);
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
                    SqlCommand command = new SqlCommand("SELECT * FROM Dyr");
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
                    SqlCommand command = new SqlCommand("INSERT INTO Dyr (KundeId, Art, Race, Alder, sex) values (@KundeId, @Art, @Race, @Alder, @sex)");
                    command.Parameters.Add(new SqlParameter("@KundeId", d.KundeId));
                    command.Parameters.Add(new SqlParameter("@Race", d.Race));
                    command.Parameters.Add(new SqlParameter("@Alder", d.Alder));
                    command.Parameters.Add(new SqlParameter("@Race", d.Race));
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
                    SqlCommand command = new SqlCommand("DELETE Dyr WHERE DyrId = @DyrId");
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
                    SqlCommand command = new SqlCommand("Update Dyr SET KundeId = @KundeId, Art = @Art, Race= @Race, Alder = @Alder, sex = @sex where DyrId = @DyrId");
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

        List<Dyr> IDyrDB.HentDyrByKundeId(int KId)
        {
            List<Dyr> ld = null;
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Dyr WHERE KundeId = @KundeId");
                    command.Parameters.Add(new SqlParameter("@KundeId", KId));
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    ld = new List<Dyr>();
                    while (reader.Read())
                    {
                        Dyr d = new Dyr();
                        d.DyrId = Convert.ToInt32(reader["DyrID"]);
                        d.KundeId = Convert.ToInt32(reader["KundeId"]);
                        d.Race = Convert.ToString(reader["Race"]);
                        d.Art = Convert.ToString(reader["Art"]);
                        d.Alder = Convert.ToInt32(reader["Alder"]);
                        d.Sex = Convert.ToChar(reader["Sex"]);
                        ld.Add(d);
                    }
                    reader.Close();
                   
                }
                catch (Exception)
                {
                    return ld;
                }
                finally
                {
                    conn.Close();
                }
            }
            return ld;
        }
    }
}
