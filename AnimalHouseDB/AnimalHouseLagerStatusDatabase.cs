using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AnimalHouse_Entities;
using AnimalHouseDB;

namespace AnimalHouseDB
{
    public class AnimalHouseLagerStatusDatabase : ILagerStatusDB
    {
        public AnimalHouseLagerStatusDatabase()
        {

        }

        //Søg i Lager tabel ved hjælp af ID
        public LagerStatus SøgStatusById (int id)
    {
        LagerStatus L = null;
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
                    L.StatusID = (int)reader["StatusID"];
                    L.VareNummer = (string)reader["VareNummer"];
                    L.VareNavn = (string)reader["VareNavn"];
                    L.MAntal = (int)reader["MAntal"];
                    L.Antal = (int)reader["Antal"];
                    L.PrisDKK = (decimal)reader["PrisDKK"];
                    L.EksMoms = (decimal)reader["EksMoms"];

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
        return L;
    }

        //Søg i Lager tabel ved hjælp af varenavn
        public string HentLagerByVareNavn(string varenummer)
        {
            string varenavn = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Select * from VareNummer" + $"where VareNummer like '{ varenummer}'";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    varenavn = (string)reader["VareNavn"];
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
            return varenavn;
        }

        //Crowd Lager tabel
        public List<LagerStatus> HentLagerStatuses()
        {
            List<LagerStatus> results = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Select * LagerStatus " + $"Join VareNummer on VareNummer.varenummer = LagerStatus.varenummer";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                results = new List<LagerStatus>();
                while (reader.Read())
                {
                    LagerStatus L = new LagerStatus();
                    L.StatusID = (int)reader["StatusID"];
                    L.VareNummer = (string)reader["VareNummer"];
                    L.VareNavn = (string)reader["VareNavn"];
                    L.MAntal = (int)reader["MAntal"];
                    L.Antal = (int)reader["Antal"];
                    L.PrisDKK = (decimal)reader["PrisDKK"];
                    L.EksMoms = (decimal)reader["EksMoms"];
                    results.Add(L);
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

        //Søg i Lager tabel ved hjælp af varenummer
        public LagerStatus HentLagerByVarenummer (string varenummer)
        {
            LagerStatus lagerstatus = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"select * from LagerStatus where Varenummer Like '%{varenummer}%;";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    lagerstatus = new LagerStatus();
                    lagerstatus.StatusID = (int)reader["StatusID"];
                    lagerstatus.VareNummer = (string)reader["VareNummer"];
                    lagerstatus.VareNavn = (string)reader["VareNavn"];
                    lagerstatus.MAntal = (int)reader["MAntal"];
                    lagerstatus.Antal = (int)reader["Antal"];
                    lagerstatus.PrisDKK = (decimal)reader["PrisDKK"];
                    lagerstatus.EksMoms = (decimal)reader["EksMoms"];

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
            return lagerstatus;
        }

        //Søg i Lager tabel ved hjælp af varenavn eller varenummer
        public List<LagerStatus> HentLagerByNavnEllerVarenummer (string input)
        {
            List<LagerStatus> results = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Select * from LagerStatus " + $"join VareNummer on VareNummer.varenumme = LagerStatus.varenummer where VareNummer on Varenummer like '%{input}%' or VareNavn like '%{input}%';";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                results = new List<LagerStatus>();
                while (reader.Read())
                {
                    LagerStatus L = new LagerStatus();
                    L.StatusID = (int)reader["StatusID"];
                    L.VareNummer = (string)reader["VareNummer"];
                    L.VareNavn = (string)reader["VareNavn"];
                    L.MAntal = (int)reader["MAntal"];
                    L.Antal = (int)reader["Antal"];
                    L.PrisDKK = (decimal)reader["PrisDKK"];
                    L.EksMoms = (decimal)reader["EksMoms"];
                    results.Add(L);
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

        public string HentLagerByVareNavn(LagerStatus L)
        {
            throw new NotImplementedException();
        }

        public List<LagerStatus> HentLagerVareByNavn(string varenavn)
        {
            throw new NotImplementedException();
        }
    }
}


