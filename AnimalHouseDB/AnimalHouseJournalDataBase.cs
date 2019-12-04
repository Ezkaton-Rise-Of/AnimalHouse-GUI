using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouse_Entities;
using System.Data.SqlClient;

namespace AnimalHouseDB
{
    public class AnimalHouseJournalDataBase : IJournal
    {
        public List<Journal> HentAlleAnsatjournal(int ansatId)
        {
            List<Journal> journals = new List<Journal>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Select * from Journial where AnsatId =@AnsatId";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                command.Parameters.Add(new SqlParameter("@AnsatId", ansatId));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Journal j = new Journal();
                    j.journalId = (int)reader["JournaliseringId"];
                    j.behandlerId = (int)reader["AnsatId"];
                    j.dyrId = (int)reader["DyrId"];
                    j.beskrivelse = (string)reader["Beskrivelse"];
                    j.dato = (DateTime)reader["Dato"];
                    journals.Add(j);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return journals;
        }

        public List<Journal> HentAlleDyrJournal(int dyrId)
        {
            List<Journal> journals = new List<Journal>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Select * from Journial where DyrId =@DyrId";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                command.Parameters.Add(new SqlParameter("@DyrId", dyrId));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Journal j = new Journal();
                    j.journalId = (int)reader["JournaliseringId"];
                    j.behandlerId = (int)reader["AnsatId"];
                    j.dyrId = (int)reader["DyrId"];
                    j.beskrivelse = (string)reader["Beskrivelse"];
                    j.dato = (DateTime)reader["Dato"];
                    journals.Add(j);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return journals;
        }

        public List<Journal> HentAlleJournal()
        {
            List<Journal> journals= new List<Journal>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Select * from Journial";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Journal j = new Journal();
                    j.journalId = (int)reader["JournaliseringId"];
                    j.behandlerId = (int)reader["AnsatId"];
                    j.dyrId = (int)reader["DyrId"];
                    j.beskrivelse = (string)reader["Beskrivelse"];
                    j.dato = (DateTime)reader["Dato"];
                    journals.Add(j);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return journals;
        }

        public string OpretJournal(Journal j)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Insert into Journial (DyrId,AnsatId,Beskrivelse) values (@DyrId,@AnsatId,@Beskrivelse)";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                command.Parameters.Add(new SqlParameter("@AnsatId", j.behandlerId));
                command.Parameters.Add(new SqlParameter("@DyrId", j.dyrId));
                command.Parameters.Add(new SqlParameter("@Beskrivelse", j.beskrivelse));
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return "Journal blev gemt!";
        }

        public string SletJournal(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Delete from Journial where JournaliserinId = @JournaliserinId";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                command.Parameters.Add(new SqlParameter("@JournaliserinId", id));
                command.ExecuteNonQuery();
            }
            catch (Exception )
            {
                return "Der sket en fejl!";
            }
            finally
            {
                conn.Close();
            }

            return "Journal blev slettet!";
        }
    }
}
