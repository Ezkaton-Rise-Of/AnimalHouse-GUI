using AnimalHouse_Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System_Entities;

namespace AnimalHouseDB
{
    public class AnimalhouseKundeDatabase : IKundeDB
    {

        public AnimalhouseKundeDatabase()
        {
        }


        // Opretelse af en kunde.
        public string OpretKunde(Kunde k)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Insert into Kunde (Fnavn,Lnavn,Adresse,Postnummer,Tlf,Kundetype,E_mail) values (@Fnavn,@Lnavn,@Adresse,@Postnummer,@Tlf,@Kundetype,@E_mail)";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                command.Parameters.Add(new SqlParameter("@Fnavn", k.Fnavn));
                command.Parameters.Add(new SqlParameter("@Lnavn", k.Lnavn));
                command.Parameters.Add(new SqlParameter("@Adresse", k.Adresse));
                command.Parameters.Add(new SqlParameter("@Postnummer", k.Postnummer));
                command.Parameters.Add(new SqlParameter("@Tlf", k.Tlf));
                command.Parameters.Add(new SqlParameter("@Kundetype", k.Kundetype));
                command.Parameters.Add(new SqlParameter("@E_mail", k.E_mail));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return "Der sket en fejl!";
                //throw;
            }
            finally
            {
                conn.Close();
            }

            return "Kunde oprettet!";
        }

        // Update en kunde info
        public string UpdateKunde(Kunde k)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Update Kunde Set Fnavn ='{k.Fnavn}',Lnavn='{k.Lnavn}', Adresse='{k.Adresse}', Postnummer='{k.Postnummer}', Tlf='{k.Tlf}', Kundetype='{k.Kundetype}', E_mail='{k.E_mail}' where KundeId ={k.Id}";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return "Der sket en fejl!";
                //throw;
            }
            finally
            {
                conn.Close();
            }

            return "Kunde updatet!";
        }

        // Kundesletning
        public string SletKunde(int id)
        {
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            SqlCommand command2 = new SqlCommand($"Delete from Kunde where KundeId ={id}", conn);
            SqlCommand command1   = new SqlCommand($"Delete from Dyr where KundeId = {id}",conn);
            
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command1.Transaction = transaction;
                command2.Transaction = transaction;
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                transaction.Commit();
                return "Kunde blev slettet!";
            }
            catch (Exception)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                throw;
                //return "slette kundernes dyr først!";
            }
            finally
            {
                conn.Close();
            }
        }

        //KundeSøning
        public Kunde HentKundeById(int id)
        {
            Kunde k = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            try
            {
                conn.Open();
                string commandtxt = $"Select * from Kunde left join Postnr on Kunde.Postnummer = Postnr.Postnummer where KundeId ={id}";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    k = new Kunde();
                    k.Id = (int)reader["KundeId"];
                    k.Fnavn = (string)reader["Fnavn"];
                    k.Lnavn = (string)reader["Lnavn"];
                    k.Adresse = (string)reader["Adresse"];
                    k.Postnummer = (string)reader["Postnummer"];
                    k.Tlf = (string)reader["Tlf"];
                    k.Kundetype = (string)reader["Kundetype"];
                    k.By = (string)reader["Bynavn"];
                    k.Oprettet = (DateTime)reader["Oprettet"];
                    k.E_mail = (string)reader["E_mail"];
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

            return k;
        }

        public List<Kunde> HentAlleKunder()
        {
            List<Kunde> results = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            
            try
            {
                conn.Open();
                string commandtxt = $"Select * from Kunde " +
                    $"join Postnr on Postnr.Postnummer = Kunde.Postnummer";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                results = new List<Kunde>();
                while (reader.Read())
                {
                    Kunde k = new Kunde();
                    k.Id = (int)reader["KundeId"];
                    k.Fnavn = (string)reader["Fnavn"];
                    k.Lnavn = (string)reader["Lnavn"];
                    k.Adresse = (string)reader["Adresse"];
                    k.Postnummer = (string)reader["Postnummer"];
                    k.Tlf = (string)reader["Tlf"];
                    k.Kundetype = (string)reader["Kundetype"];
                    k.By = (string)reader["Bynavn"];
                    k.Oprettet = (DateTime)reader["Oprettet"];
                    k.E_mail = (string)reader["E_mail"];
                    results.Add(k);
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

            return results;
        }

        public string HentByNavn(string postnr)
        {
            string bynavn = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            
            try
            {
                conn.Open();
                string commandtxt = $"Select * from Postnr " +
                    $"where Postnummer like '{postnr}'";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    bynavn = (string)reader["Bynavn"];
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

            return bynavn;
        }

        public Kunde HentKundeByTlf(string tlf)
        {
            Kunde kunde = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            
            try
            {
                conn.Open();
                string commandtxt = $"select * from Kunde Join Postnr on Kunde.Postnummer = Postnr.Postnummer where Tlf Like '%{tlf}%'";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    kunde = new Kunde();
                    kunde.Id = (int)reader["KundeId"];
                    kunde.Fnavn = (string)reader["Fnavn"];
                    kunde.Lnavn = (string)reader["Lnavn"];
                    kunde.Adresse = (string)reader["Adresse"];
                    kunde.Postnummer = (string)reader["Postnummer"];
                    kunde.By = (string)reader["Bynavn"];
                    kunde.Tlf = (string)reader["Tlf"];
                    kunde.Kundetype = (string)reader["Kundetype"];
                    kunde.E_mail = (string)reader["E_mail"];
                    kunde.Oprettet = (DateTime)reader["Oprettet"];
                }
            }
            catch (Exception et)
            {
                throw et;
            }
            finally
            {
                conn.Close();
            }

            return kunde;
        }

        public List<Kunde> HentKunderByTlfOrNavn(string input)
        {
            List<Kunde> results = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            
            try
            {
                conn.Open();
                string commandtxt = $"Select * from Kunde " +
                    $"join Postnr on Postnr.Postnummer = Kunde.Postnummer where Tlf like '%{input}%' or Fnavn like '%{input}%';";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                results = new List<Kunde>();
                while (reader.Read())
                {
                    Kunde k = new Kunde();
                    k.Id = (int)reader["KundeId"];
                    k.Fnavn = (string)reader["Fnavn"];
                    k.Lnavn = (string)reader["Lnavn"];
                    k.Adresse = (string)reader["Adresse"];
                    k.Postnummer = (string)reader["Postnummer"];
                    k.Tlf = (string)reader["Tlf"];
                    k.Kundetype = (string)reader["Kundetype"];
                    k.By = (string)reader["Bynavn"];
                    k.Oprettet = (DateTime)reader["Oprettet"];
                    k.E_mail = (string)reader["E_mail"];
                    results.Add(k);
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

            return results;
        }

        public int HentKundeId(string input)
        {
            int id = 0;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            try
            {
                conn.Open();
                string commandtxt = $"select KundeId from Kunde where Tlf Like '%{input}%' or Fnavn Like '%{input}%'";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = (int)reader["KundeId"];
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return id;
        }
    }
}