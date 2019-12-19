using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System_Entities;

namespace AnimalHouseDB
{
    public class AnimalHouseSalgDataBase : ISalg
    {
        public string GemFaktura(Faktura f)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                SqlCommand command = new SqlCommand($"insert into Faktura(KundeId,Total,Rabat,Produkter)values({f.KundeId},'{f.Total}','{f.Rabat}','{f.Produkter}');", conn);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    return "faktura blev gemt!";
                }
                catch (Exception)
                {
                    //return "Der sket en fejl!";
                    throw;
                }
                finally { conn.Close(); }
            }
        }

        public List<Faktura> HentKundesFaktura(int kundeId)
        {
            List<Faktura> res = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                SqlTransaction transaction = null;
                res = new List<Faktura>();
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    SqlCommand command = new SqlCommand("Select * from Faktura where KundeId = @kundeId", conn, transaction);
                    command.Parameters.Add(new SqlParameter("@kundeId", kundeId));
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Faktura f = new Faktura();
                        f.FakturaId = Convert.ToInt32(reader["FakturaId"]);
                        f.KundeId = Convert.ToInt32(reader["KundeId"]);
                        f.Dato = Convert.ToDateTime(reader["Dato"]);
                        f.Total = reader["Total"].ToString();
                        f.Rabat = reader["Rabat"].ToString();
                        res.Add(f);
                    }
                    reader.Close();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    throw new NotImplementedException();
                }
                finally { conn.Close(); }
                return res;
            }
        }

        public List<Faktura> HentAlleFaktura()
        {
            List<Faktura> res = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                SqlTransaction transaction = null;
                res = new List<Faktura>();
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    SqlCommand command = new SqlCommand("Select * from Faktura;", conn, transaction);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Faktura f = new Faktura();
                        f.FakturaId = Convert.ToInt32(reader["FakturaId"]);
                        f.KundeId = Convert.ToInt32(reader["KundeId"]);
                        f.Dato = Convert.ToDateTime(reader["Dato"]);
                        f.Total = reader["Total"].ToString();
                        f.Rabat = reader["Rabat"].ToString();
                        f.Produkter = reader["Produkter"].ToString();
                        res.Add(f);
                    }
                    reader.Close();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    throw;
                }
                finally { conn.Close(); }
                return res;
            }
        }
    }
}
