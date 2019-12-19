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


        //Søg i tabel ved hjælp af ID
        public Lager SøgId(int produktid)
        {
            Lager L = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Select * from Lager inner join Produkt.ProduktId = Lager.ProduktId where ProduktId ={produktid}";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                L = new Lager();
                if (reader.Read())
                {
                    Produkt p = new Produkt();
                    p.ProduktId = (int)reader["ProduktId"];
                    p.Beskrivelse = (string)reader["Beskrivelse"];
                    p.Pris = (double)reader["Pris"];
                    p.KategoriId = (int)reader["KategoriId"];
                    Lager lagervare = new Lager();
                    lagervare.Produkt = p;
                    lagervare.Pris = (double)reader["Pris"];
                    lagervare.Antal = (int)reader["Antal"];
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

        public List<Lager> HentLager()
        {
            List<Lager> results = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Select * from Lager";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                results = new List<Lager>();
                while (reader.Read())
                {
                    Lager lagervare = new Lager();
                    lagervare.Pris = Convert.ToDouble(reader["Pris"]);
                    lagervare.Antal = Convert.ToInt32(reader["Antal"]);
                    lagervare.ProduktId = Convert.ToInt32(reader["ProduktId"]);
                    results.Add(lagervare);
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return results;
        }

        public string TilføjLager (Lager L)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"Insert into Lager (Pris, Antal, Produkt) values (@Pris, @Antal, @ProduktId)";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                command.Parameters.Add(new SqlParameter("@Pris", L.Pris));
                command.Parameters.Add(new SqlParameter("@Antal", L.Antal));
                command.Parameters.Add(new SqlParameter("@Produkt", L.Produkt));
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conn.Close();
            }

            return "Produkt tilføjet til lager";
        }
    }
}
