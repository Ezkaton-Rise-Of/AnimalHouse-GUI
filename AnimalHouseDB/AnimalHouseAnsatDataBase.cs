using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Entities;
using System.Data.SqlClient;
using System.Configuration;
using AnimalHouseDB;

namespace AnimalHouseDataBase
{
    public class AnimalHouseAnsatDataBase : IAnsatDB
    {
        public AnimalHouseAnsatDataBase()
        {
        }

        public List<Ansat> HentAlleAnsate()
        {
            List<Ansat> a = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    string commandtxt = $"select * from Ansat;";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    a = new List<Ansat>();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Ansat ansat = new Ansat();
                        ansat.Id = (int)reader["AnsatId"];
                        ansat.Navn = (string)reader["Navn"];
                        ansat.Ansattype = (int)reader["Ansattype"];
                        a.Add(ansat);
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
            return a;
        }

        public Ansat HentAnsatById(int ansatId)
        {
            Ansat a = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    string commandtxt = $"select * from Ansat where AnsatId = {ansatId};";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        a.Id = (int)reader["AnsatId"];
                        a.Navn = (string)reader["Navn"];
                        a.Ansattype = (int)reader["Ansattype"];
                    }
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return a;
        }

        public Ansat HentAnsatByNavn(string ansatNavn)
        {
            Ansat a = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    string commandtxt = $"select * from Ansat where Navn = {ansatNavn};";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        a.Id = (int)reader["AnsatId"];
                        a.Navn = (string)reader["Navn"];
                        a.Ansattype = (int)reader["Ansattype"];
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
            return a;
        }

        public List<Ansat> HentAnsateByType(int ansattype)
        {
          List<Ansat> a = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    string commandtxt = $"select * from Ansat where Ansattype = {ansattype};";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    a = new List<Ansat>();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Ansat ansat = new Ansat();
                        ansat.Id = (int)reader["AnsatId"];
                        ansat.Navn = (string)reader["Navn"];
                        ansat.Ansattype = (int)reader["Ansattype"];
                        a.Add(ansat);
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
            return a;
        }

        public string OpretAnsat(Ansat a)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    string commandtxt = $"Insert into Ansat (Navn,Ansattype) values (@Navn,@Ansattype)";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    command.Parameters.Add(new SqlParameter("@Navn", a.Navn));
                    command.Parameters.Add(new SqlParameter("@Ansattype",a.Ansattype));
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return "Kunde oprettet!";
        }

        public string SletAnsat(int ansatId)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    string commandtxt = $"Delete from Ansat where AnsatId =@AnsatId";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    command.Parameters.Add(new SqlParameter("@AnsatId", ansatId));
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return "Ansat blev slettet!";
        }

        public string UpdateAnsat(Ansat a)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand command = new SqlCommand("Update Ansat Set Navn = @Navn, Ansattype = @Ansattype where AnsatId = @AnsatId");
                    command.Parameters.Add(new SqlParameter("@AnsatId", a.Id));
                    command.Parameters.Add(new SqlParameter("@Navn", a.Navn));
                    command.Parameters.Add(new SqlParameter("@Ansattype", a.Ansattype));
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return "Ansat blev updatet!";
        }
    }
}
