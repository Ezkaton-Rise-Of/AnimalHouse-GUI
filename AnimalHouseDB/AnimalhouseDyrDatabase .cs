//Holger
using AnimalHouse_Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace AnimalHouseDB
{
    public class AnimalhouseDyrDatabase : IDyrDB
    {
        public AnimalhouseDyrDatabase()
        {
        }

        public List<Dyr> HentAlleDyr()
        {

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                List<Dyr> ld = null;
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    SqlCommand command = new SqlCommand("select * from Dyr Left join Dyr_Has_Læge on dyr.DyrId = Dyr_Has_Læge.DyrId", conn);
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
                        d.Tilknyttet_Behandler = Convert.ToString(reader["Tilknyttet_behandler"]);

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
          
        }
        public Dyr HentDyr(int Id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                Dyr d = null;
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
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
                return d;
            }
        }

        public string OpretDyr(Dyr d)
        {
            string result;
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
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
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
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
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
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
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                List<Dyr> ld = null;
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
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
        public void TilknytBehandler(int dyrId, string behandler)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                SqlCommand command = new SqlCommand($"update Dyr Set Tilknyttet_behandler = '{behandler}' where DyrId ={dyrId}", conn);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
