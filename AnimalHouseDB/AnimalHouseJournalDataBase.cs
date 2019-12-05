using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Entities;
using System.Data.SqlClient;
using System.Configuration;

namespace AnimalHouseDB
{
    public class AnimalHouseJournalDataBase : IJournal
    {
        public List<Journal> HentAlleAnsatJournale(int ansatid)
        {
            List<Journal> j;
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Journial where AnsatId = @AnsatId", conn);
                    command.Parameters.Add(new SqlParameter("@AnsatId", ansatid));
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    j = new List<Journal>();
                    while (reader.Read())
                    {
                        Journal jo = new Journal();
                        jo.journalId = Convert.ToInt32(reader["JournaliseringId"]);
                        jo.behandlerId = Convert.ToInt32(reader["AnsatId"]);
                        jo.dyrId = Convert.ToInt32(reader["DyrId"]);
                        jo.beskrivelse = Convert.ToString(reader["Beskrivelse"]);
                        jo.dato = Convert.ToDateTime(reader["Dato"]);

                        j.Add(jo);
                    }
                    reader.Close();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return j;
        }

        public List<Journal> HentAlleDyrJournale(int dyrid)
        {
            List<Journal> j;
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Journial where DyrId = @DyrId", conn);
                    command.Parameters.Add(new SqlParameter("@DyrId", dyrid));
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    j = new List<Journal>();
                    while (reader.Read())
                    {
                        Journal jo = new Journal();
                        jo.journalId = Convert.ToInt32(reader["JournaliseringId"]);
                        jo.behandlerId = Convert.ToInt32(reader["AnsatId"]);
                        jo.dyrId = Convert.ToInt32(reader["DyrId"]);
                        jo.beskrivelse = Convert.ToString(reader["Beskrivelse"]);
                        jo.dato = Convert.ToDateTime(reader["Dato"]);

                        j.Add(jo);
                    }
                    reader.Close();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return j;
        }

        public List<Journal> HentAlleJournale()
        {
            List<Journal> j;
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Journial", conn);
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    j = new List<Journal>();
                    while (reader.Read())
                    {
                        Journal jo = new Journal();
                        jo.journalId = Convert.ToInt32(reader["JournaliseringId"]);
                        jo.behandlerId = Convert.ToInt32(reader["AnsatId"]);
                        jo.dyrId = Convert.ToInt32(reader["DyrId"]);
                        jo.beskrivelse = Convert.ToString(reader["Beskrivelse"]);
                        jo.dato = Convert.ToDateTime(reader["Dato"]);

                        j.Add(jo);
                    }
                    reader.Close();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return j;
        }

        public Journal HentJournal(int id)
        {
            Journal j;
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Journial", conn);
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    j = new Journal();
                    if (reader.Read())
                    {
                        j.journalId = Convert.ToInt32(reader["JournaliseringId"]);
                        j.behandlerId = Convert.ToInt32(reader["AnsatId"]);
                        j.dyrId = Convert.ToInt32(reader["DyrId"]);
                        j.beskrivelse = Convert.ToString(reader["Beskrivelse"]);
                        j.dato = Convert.ToDateTime(reader["Dato"]);
                    }
                    reader.Close();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return j;
        }

        public string OpretJournal(Journal j)
        {
            string result;
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Journial (DyrId, AnsatId,beskrivelse) values (@DyrId, @AnsatId, @Beskrivelse)", conn);
                    command.Parameters.Add(new SqlParameter("@DyrId",j.dyrId));
                    command.Parameters.Add(new SqlParameter("@AnsatId", j.behandlerId));
                    command.Parameters.Add(new SqlParameter("@Beskrivelse", j.beskrivelse));
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    result = "Journal blev gemt!";
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

        public string SletJournal(int id)
        {
            string result;
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("delete from Journial where JournaliseringId = @Id", conn);
                    command.Parameters.Add(new SqlParameter("@Id", id));
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    result = "Journal blev slettet!";
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
    }
}
