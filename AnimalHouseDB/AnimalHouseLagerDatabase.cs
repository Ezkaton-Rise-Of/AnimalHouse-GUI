using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AnimalHouse_Entities;
using AnimalHouseDB;

namespace AnimalHouseDB
{
    public class AnimalHouseLagerDatabase : ILagerDB
    {
        public AnimalHouseLagerDatabase()
        {

        }

        public List<Lager> HentLager()
        {
            throw new NotImplementedException();
        }

        public List<Lager> HentLagerNavnEllerVareNummer(string input)
        {
            throw new NotImplementedException();
        }

        public Lager HentLagerVareNummer(string varenummer)
        {
            throw new NotImplementedException();
        }

        //Søg i tabel ved hjælp af ID
        public Lager SøgId(int id)
        {
            Lager L = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try 
            {
                string commandtxt = $"Select * from Lager inner join Produkt.ProduktId = Lager.ProduktId where Id ={id}";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                L = new Lager();
                if (reader.Read())
                {
                    Produkt p = new Produkt();
                    p.ProduktId = (int)reader["ProduktId"];
                    p.Beskrivelse = (string)reader["Beskrivelse"];
                    p.Pris = (decimal)reader["Price"];
                    p.KategoriId = (int)reader["KategoriId"];
                    Lager lagervare = new Lager();
                    lagervare.produkt = p;
                    lagervare.voresPris = (decimal)reader["VoresPris"];
                    lagervare.antal = (int)reader["Antal"];
                    L.LagerList.Add(lagervare);
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
        //public Lager HentLagerVareNavn(string varenavn)
        //{
        //    Lager lager = null;
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
        //    conn.Open();
        //    try
        //    {
        //        string commandtxt = $"select * from Lager where VareNavn Like '%{varenavn}%;";
        //        SqlCommand command = new SqlCommand(commandtxt, conn);
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            lager = new Lager();
        //            lager.ID = (int)reader["ID"];
        //            lager.VareNummer = (string)reader["VareNummer"];
        //            lager.VareNavn = (string)reader["VareNavn"];
        //            lager.MinAntal = (int)reader["MinAntal"];
        //            lager.Antal = (int)reader["Antal"];
        //            lager.Pris = (decimal)reader["Pris"];
        //            lager.EksMoms = (decimal)reader["EksMoms"];

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return lager;
        //}

        //Søg i Lager tabel ved hjælp af varenummer
        //public Lager HentLagerVareNummer(string varenummer)
        //{
        //    Lager lager = null;
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
        //    conn.Open();
        //    try
        //    {
        //        string commandtxt = $"select * from Lager where VareNummer Like '%{varenummer}%;";
        //        SqlCommand command = new SqlCommand(commandtxt, conn);
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            lager = new Lager();
        //            lager.ID = (int)reader["ID"];
        //            lager.VareNummer = (string)reader["VareNummer"];
        //            lager.VareNavn = (string)reader["VareNavn"];
        //            lager.MinAntal = (int)reader["MinAntal"];
        //            lager.Antal = (int)reader["Antal"];
        //            lager.Pris = (decimal)reader["Pris"];
        //            lager.EksMoms = (decimal)reader["EksMoms"];

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return lager;
        //}

        //Crowd Lager tabel
        //public List<Lager> HentLager()
        //{
        //    List<Lager> results = null;
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
        //    conn.Open();
        //    try
        //    {
        //        string commandtxt = $"Select * Lager " + $"Join VareNummer on VareNummer.varenummer = Lager.varenummer";
        //        SqlCommand command = new SqlCommand(commandtxt, conn);
        //        SqlDataReader reader = command.ExecuteReader();
        //        results = new List<Lager>();
        //        while (reader.Read())
        //        {
        //            Lager L = new Lager();
        //            L.ID = (int)reader["Id"];
        //            L.VareNummer = (string)reader["VareNummer"];
        //            L.VareNavn = (string)reader["VareNavn"];
        //            L.MinAntal = (int)reader["MinAntal"];
        //            L.Antal = (int)reader["Antal"];
        //            L.Pris = (decimal)reader["Pris"];
        //            L.EksMoms = (decimal)reader["EksMoms"];
        //            results.Add(L);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return results;
        //}


        //Søg i Lager tabel ved hjælp af varenavn eller varenummer
        //public List<Lager> HentLagerNavnEllerVareNummer(string input)
        //{
        //    List<Lager> results = null;
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
        //    conn.Open();
        //    try
        //    {
        //        string commandtxt = $"Select * from Lager " + $"join VareNummer on VareNummer.varenumme = Lager.varenummer where VareNummer on Varenummer like '%{input}%' or VareNavn like '%{input}%';";
        //        SqlCommand command = new SqlCommand(commandtxt, conn);
        //        SqlDataReader reader = command.ExecuteReader();
        //        results = new List<Lager>();
        //        while (reader.Read())
        //        {
        //            Lager L = new Lager();
        //            L.ID = (int)reader["ID"];
        //            L.VareNummer = (string)reader["VareNummer"];
        //            L.VareNavn = (string)reader["VareNavn"];
        //            L.MinAntal = (int)reader["MinAntal"];
        //            L.Antal = (int)reader["Antal"];
        //            L.Pris = (decimal)reader["Pris"];
        //            L.EksMoms = (decimal)reader["EksMoms"];
        //            results.Add(L);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return results;
        //}

        List<Lager> ILagerDB.HentLagerVareNavn(string varenavn)
        {
            throw new NotImplementedException();
        }
    }
}
