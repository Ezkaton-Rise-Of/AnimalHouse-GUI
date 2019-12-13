using AnimalHouse_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Transactions;
namespace AnimalHouseDB
{
    class AnimalHouseProduktDatabase : IProduktDB
    {
        public List<Kategori> HentAlleKategorier()
        {
            List<Kategori> kategoriList = null;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {

                kategoriList = new List<Kategori>();
                SqlCommand command = new SqlCommand("select * from Produkt_Kategori", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                { 
                    Kategori kategori = new Kategori(Convert.ToInt32(reader["Produkt_KategoriId"]), Convert.ToString(reader[".Produkt_Kategori.Navn"]));
                    kategoriList.Add(kategori);
                }

                command.Transaction = transaction;
                command.ExecuteNonQuery();
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
            return kategoriList;
        }

        public List<Produkt> HentAlleProduktByKategori(Kategori k)
        {
            List<Produkt> produkts = null;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {

                produkts = new List<Produkt>();
                SqlCommand command = new SqlCommand("select * from Produkt join Produkt_Kategori on Produkt.ProduktKategoriId = Produkt_Kategori.Produkt_KategoriId where Produkt.ProduktKategoriId = @kategori", conn);
                command.Parameters.Add(new SqlParameter("@Kategori", k.KategoriId));

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Produkt item = new Produkt();
                    item.ProduktId = Convert.ToInt32(reader["ProduktId"]);
                    item.Beskrivelse = Convert.ToString(reader["Beskrivelse"]);
                    item.Pris = Convert.ToDouble(reader["Pris"]);
                    item.kategori = new Kategori(Convert.ToInt32(reader["Produkt_KategoriId"]), Convert.ToString(reader[".Produkt_Kategori.Navn"]));
                    item.Service = Convert.ToBoolean(reader["Service"]);
                    item.Navn = Convert.ToString(reader["Navn"]);
                    produkts.Add(item);
                }

                command.Transaction = transaction;
                command.ExecuteNonQuery();
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
            return produkts;
        }

        public List<Produkt> HentAlleProdukter()
        {

            List<Produkt> produkts = null;
                SqlTransaction transaction = null;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {

                        produkts = new List<Produkt>();
                        SqlCommand command = new SqlCommand("select * from Produkt join Produkt_Kategori on Produkt.ProduktKategoriId = Produkt_Kategori.Produkt_KategoriId", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                {
                    Produkt item = new Produkt();
                    item.ProduktId = Convert.ToInt32(reader["ProduktId"]);
                    item.Beskrivelse = Convert.ToString(reader["Beskrivelse"]);
                    item.Pris = Convert.ToDouble(reader["Pris"]);
                    item.kategori = new Kategori(Convert.ToInt32(reader["Produkt_KategoriId"]), Convert.ToString(reader[".Produkt_Kategori.Navn"]));
                    item.Service = Convert.ToBoolean(reader["Service"]);
                    item.Navn = Convert.ToString(reader["Navn"]);

                    produkts.Add(item);
                }

                command.Transaction = transaction;
                    command.ExecuteNonQuery();
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
                return produkts;
        }

        public Produkt HentProdukt(int Id)
        {

            Produkt produkt = null;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {

                
                SqlCommand command = new SqlCommand("select * from Produkt join Produkt_Kategori on Produkt.ProduktKategoriId = Produkt_Kategori.Produkt_KategoriId where ProduktId = @produktId ", conn);
                command.Parameters.Add(new SqlParameter("@produktId", Id));

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    produkt = new Produkt();
                    produkt.ProduktId = Convert.ToInt32(reader["ProduktId"]);
                    produkt.Beskrivelse = Convert.ToString(reader["Beskrivelse"]);
                    produkt.Pris = Convert.ToDouble(reader["Pris"]);
                    produkt.kategori = new Kategori(Convert.ToInt32(reader["Produkt_KategoriId"]), Convert.ToString(reader[".Produkt_Kategori.Navn"]));
                    produkt.Service = Convert.ToBoolean(reader["Service"]);
                    produkt.Navn = Convert.ToString(reader["Navn"]);
                }
                command.Transaction = transaction;
                command.ExecuteNonQuery();
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
            return produkt;
        }

        public bool UpdaterProdukt(Produkt p)
        {
            bool answer = false;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand("update Produkt set Beskrivelse = @beskrivelse, Pris = @Pris, Navn = @Navn where Produkt.ProduktId = @ProduktId", conn);
                command.Parameters.Add(new SqlParameter("@beskrivelse", p.Beskrivelse));
                command.Parameters.Add(new SqlParameter("@Pris", p.Pris));
                command.Parameters.Add(new SqlParameter("@Navn", p.Navn));
                command.Parameters.Add(new SqlParameter("@ProduktId", p.ProduktId));
                command.Transaction = transaction;
                command.ExecuteNonQuery();
                transaction.Commit();
                answer = true;
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
            return answer;
        }
    }
}
