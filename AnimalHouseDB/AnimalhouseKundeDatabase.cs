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
    public class AnimalhouseKundeDatabase: IKundeDB
    {

        public AnimalhouseKundeDatabase()
        {
        }


        // Opretelse af en kunde.
        public string OpretKunde( Kunde k) 
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
                try
                {
                    string commandtxt = $"Insert into Kunde (Fnavn,Lnavn,Adresse,Postnummer,Tlf,Kundetype,E_mail) values (@Fnavn,@Lnavn,@Adresse,@Postnummer,@Tlf,@Kundetype,@E_mail)";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    command.Parameters.Add(new SqlParameter("@Fnavn", k.Fnavn));
                    command.Parameters.Add(new SqlParameter("@Lnavn", k.Fnavn));
                    command.Parameters.Add(new SqlParameter("@Adresse", k.Adresse));
                    command.Parameters.Add(new SqlParameter("@Postnummer", k.Postnummer));
                    command.Parameters.Add(new SqlParameter("@Tlf", k.Tlf));
                    command.Parameters.Add(new SqlParameter("@Kundetype", k.Kundetype));
                    command.Parameters.Add(new SqlParameter("@E_mail", k.E_mail));

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
                    SqlCommand command = new SqlCommand("Update kunde Set Fnavn = @Fnavn, Lnavn = @Lnavn, Adresse = @Adresse, Postnummer = @Postnummer,Tlf= @Tlf, Kundetype= @kundetype, E_mail = @E_mail where KundeId = @kundeId");
                    command.Parameters.Add(new SqlParameter("@KundeId", k.Id));
                    command.Parameters.Add(new SqlParameter("@Fnavn", k.Fnavn));
                    command.Parameters.Add(new SqlParameter("@Lnavn", k.Lnavn));
                    command.Parameters.Add(new SqlParameter("@Adresse", k.Adresse));
                    command.Parameters.Add(new SqlParameter("@Postnummer", k.Postnummer));
                    command.Parameters.Add(new SqlParameter("@Tlf", k.Tlf));
                    command.Parameters.Add(new SqlParameter("@kundetype", k.Kundetype));
                    command.Parameters.Add(new SqlParameter("@E_mail", k.E_mail));
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
            
            return "Kunde updatet!";
        }

        // Kundesletning
        public string SletKunde(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
                try
                {
                    string commandtxt = $"Delete from Kunde where KundeId ={id}";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
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
            
            return "Kunde blev slettet!";
        }

        //KundeSøning
        public Kunde HentKundeById(int id)
        {
            Kunde k = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
                try
                {
                    string commandtxt = $"Select * from Kunde left join Postnr on Kunde.Postnummer = Postnr.Postnummer where KundeId ={id}";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        k.Id =(int)reader["KundeId"];
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

        // Søge en Kunde via ders telfon nummer.
        public Kunde HentKundeByTlf(string tlf)
        {
            Kunde k = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
                try
                {
                    string commandtxt = $"Select * from Kunde where Tlf like '{tlf}'";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        k.Id = (int)reader["KundeId"];
                        k.Fnavn = (string)reader["Fnavn"];
                        k.Lnavn = (string)reader["Lnavn"];
                        k.Adresse = (string)reader["Adresse"];
                        k.Tlf = (string)reader["Tlf"];
                        k.Kundetype = (string)reader["Kundetype"];
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
            conn.Open();
                try
                {
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
            conn.Open();
                try
                {
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
    }
}
