using AnimalHouse_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace AnimalHouseDB
{
    public class AnimalHouseProduktDatabase : IProduktDB
    {
        SqlTransaction transaction = null;
        SqlConnection conn = new SqlConnection("Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V");
        public AnimalHouseProduktDatabase()
        {
        }
        public List<Kategori> HentAlleKategorier()
        {
            List<Kategori> kategoriList = null;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                kategoriList = new List<Kategori>();
                SqlCommand command = new SqlCommand("select * from Produkt_Kategori", conn, transaction);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Kategori kategori = new Kategori();
                        kategori.KategoriId = Convert.ToInt32(reader["Produkt_KategoriId"]);
                        kategori.KategoriNavn = Convert.ToString(reader["Navn"]);
                        kategoriList.Add(kategori);
                    }
                    reader.Close();
                }
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
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                produkts = new List<Produkt>();
                SqlCommand command = new SqlCommand("select * from Produkt join Produkt_Kategori on Produkt.ProduktKategoriId = Produkt_Kategori.Produkt_KategoriId where Produkt.ProduktKategoriId = @kategori", conn, transaction);
                command.Parameters.Add(new SqlParameter("@Kategori", k.KategoriId));

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Produkt item = new Produkt();
                    item.ProduktId = Convert.ToInt32(reader["ProduktId"]);
                    item.Beskrivelse = Convert.ToString(reader["Beskrivelse"]);
                    item.Pris = Convert.ToDouble(reader["Pris"]);
                    item.kategori = new Kategori(Convert.ToInt32(reader["Produkt_KategoriId"]), Convert.ToString(reader["Navn"]));
                    item.Service = Convert.ToBoolean(reader["Service"]);
                    item.Navn = Convert.ToString(reader["Navn"]);
                    produkts.Add(item);
                }
                reader.Close();
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
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                produkts = new List<Produkt>();
                SqlCommand command = new SqlCommand("select * from Produkt join Produkt_Kategori on Produkt.ProduktKategoriId = Produkt_Kategori.Produkt_KategoriId", conn,transaction);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Produkt item = new Produkt();
                    item.ProduktId = Convert.ToInt32(reader["ProduktId"]);
                    item.Beskrivelse = Convert.ToString(reader["Beskrivelse"]);
                    item.Pris = Convert.ToDouble(reader["Pris"]);
                    item.kategori = new Kategori(Convert.ToInt32(reader["Produkt_KategoriId"]), Convert.ToString(reader["Navn"]));
                    item.Service = Convert.ToBoolean(reader["Service"]);
                    item.Navn = Convert.ToString(reader["Navn"]);
                    item.KategoriId = Convert.ToInt32(reader["Produkt_KategoriId"]);

                    produkts.Add(item);
                }
                reader.Close();
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
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                SqlCommand command = new SqlCommand("select * from Produkt join Produkt_Kategori on Produkt.ProduktKategoriId = Produkt_Kategori.Produkt_KategoriId where ProduktId = @produktId ", conn,transaction);
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
                    produkt.KategoriId = Convert.ToInt32(reader["Produkt_KategoriId"]);
                }
                reader.Close();
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
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                SqlCommand command = new SqlCommand("update Produkt set Beskrivelse = @beskrivelse, Pris = @Pris, Navn = @Navn where Produkt.ProduktId = @ProduktId", conn,transaction);
                command.Parameters.Add(new SqlParameter("@beskrivelse", p.Beskrivelse));
                command.Parameters.Add(new SqlParameter("@Pris", p.Pris));
                command.Parameters.Add(new SqlParameter("@Navn", p.Navn));
                command.Parameters.Add(new SqlParameter("@ProduktId", p.ProduktId));
                command.ExecuteNonQuery();
                transaction.Commit();
                answer = true;
            }
            catch (Exception e)
            {
                answer = false;
                transaction.Rollback();
                throw e;
            }
            finally
            {
                conn.Close();
            }
            return answer;
        }
        //Holger
        public bool ProduktFromExtern(List<Produkt> Lines)
        {
            bool answer = false;
            foreach  (Produkt item in Lines)
            {
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    //henter leverandørId     
                    int id = -1; //HentSupplier(item.Supplier.SupplierNavn);
                    //
                    if (id == -1)
                    {
                        id = InsertSupplier(item.Supplier.SupplierNavn);
                    }
                    SqlCommand commandUpdate = new SqlCommand($"if 1 = (select count(*) from Produkt where VareNummer = @varenummer and SupplierId = {id})" +
                        $"update Produkt set Beskrivelse = @beskrivelse, Pris = @Pris, Navn = @Navn where VareNummer = @varenummer and SupplierId = {id} " +
                        $"else insert into Produkt (Beskrivelse, Pris, Navn, VareNummer, SupplierId, Service) values (@beskrivelse, @Pris, @Navn, @varenummer, {id}, 0); ", conn, transaction);
                    commandUpdate.Parameters.Add(new SqlParameter("@beskrivelse", item.Beskrivelse));
                    commandUpdate.Parameters.Add(new SqlParameter("@Pris", item.Pris));
                    commandUpdate.Parameters.Add(new SqlParameter("@Navn", item.Navn));
                    commandUpdate.Parameters.Add(new SqlParameter("@varenummer", item.varenummer));


                    commandUpdate.ExecuteNonQuery();
                    transaction.Commit();
                    answer = true;
                }
                catch (Exception e)
                {
                    answer = false;
                    transaction.Rollback();
                    throw e;
                }
                finally
                {
                    conn.Close();
                }
            }
            
            return answer;
        }

        private Int32 InsertSupplier(string navn)
        {
            Int32 id = -1;
            try
            {
                //insert into(SupplierNavn) values(@supplierNavn); SELECT CAST(scope_identity() AS int);
                SqlCommand commandInsertSupplier = new SqlCommand("insert into Supplier(SupplierNavn) values(@supplierNavn); SELECT CAST(scope_identity() AS int); ", conn, transaction);
                commandInsertSupplier.Parameters.Add(new SqlParameter("@supplierNavn", navn));
                id = (Int32)commandInsertSupplier.ExecuteScalar();

            }
            catch (Exception t)
            {
                throw t;
            }
            return id;
        }
        private int HentSupplier(string navn)
        {
            int id = -1;
            try {
                
                SqlCommand commandSelectleverandør = new SqlCommand("select top 1 SupplierId from Supplier where SupplierNavn = @SupplierNavn; ", conn, transaction);
                commandSelectleverandør.Parameters.Add(new SqlParameter("@SupplierNavn", navn));
                SqlDataReader reader = commandSelectleverandør.ExecuteReader();
                while (reader.Read())
                {
                    id = (int)reader["SupplierId"];
                }
                reader.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return id;
        }

    }
}
