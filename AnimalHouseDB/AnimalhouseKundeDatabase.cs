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
    public class AnimalhouseKundeDatabase
    {

        public AnimalhouseKundeDatabase()
        {
        }


        // Opretelse af en kunde.
        public string OpretKunde( Kunde k) 
        {
            using(SqlConnection conn = new SqlConnection( ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
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
            }
            return "Kunde oprettet!";
        }

        // Update en kunde info
        public string UpdateKunde(Kunde k, int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    string commandtxt = $"update Kunde set Fnavn = '{k.Fnavn}',Lnavn = '{k.Lnavn}',Adresse = '{k.Adresse}',Postnummer = '{k.Postnummer}',Tlf= '{k.Tlf}',Kundetype= '{k.Kundetype}' where KundeId ={id}";
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
            }
            return "Kunde updatet!";
        }

        // Kundesletning
        public string DeleteKunde(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
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
            }
            return "Kunde blev slettet!";
        }

        //KundeSøning
        public Kunde SearchForKunde(int id)
        {
            Kunde k = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                conn.Open();
                try
                {
                    string commandtxt = $"Select * from Kunde left joinwhere KundeId ={id}";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        k.Id =(int)reader["KundeId"];
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
            }
            return k;
        }
    }
}
