﻿using AnimalHouse_Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
namespace AnimalHouseDB
{
    public class AnimalHouseAnsatDataBase : IAnsatDB
    {
        public AnimalHouseAnsatDataBase()
        {
        }

        public List<Ansat> HentAlleAnsatte()
        {
            List<Ansat> a = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
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
                    ansat.Stelling = (string)reader["Stelling"];
                    ansat.Tlf = (string)reader["Tlf"];
                    a.Add(ansat);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }

            return a;
        }


        public Ansat HentAnsat(int ansatId)
        {
            Ansat a = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=den1.mssql8.gear.host; Initial Catalog=test102; User Id=test102; Password=Ld8m8N!-wV0V";
            conn.Open();
            try
            {
                string commandtxt = $"select * from Ansat where AnsatId = {ansatId};";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    a = new Ansat();
                    a.Id = (int)reader["AnsatId"];
                    a.Navn = (string)reader["Navn"];
                    a.Stelling = (string)reader["Stelling"];
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }

            return a;
        }

        public Ansat HentAnsatByNavn(string ansatNavn)
        {

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                string commandtxt = $"select * from Ansat where Navn like '%{ansatNavn}%';";
                SqlCommand command = new SqlCommand(commandtxt, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Ansat ansat = new Ansat();
                        ansat.Id = (int)reader["AnsatId"];
                        ansat.Navn = (string)reader["Navn"];
                        ansat.Stelling = (string)reader["Stelling"];
                        ansat.Tlf = (string)reader["Tlf"];
                        return ansat;
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    conn.Close();
                }

                return null;
            }
        }

        public List<Ansat> HentAnsatByNavn2(string ansatNavn)
        {
            List<Ansat> a = new List<Ansat>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string commandtxt = $"select * from Ansat where Navn like '%{ansatNavn}%';";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Ansat ansat = new Ansat();
                        ansat.Id = (int)reader["AnsatId"];
                        ansat.Navn = (string)reader["Navn"];
                        ansat.Stelling = (string)reader["Stelling"];
                        ansat.Tlf = (string)reader["Tlf"];
                        a.Add(ansat);
                    }
                }
                catch (Exception)
                {

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

                try
                {
                    conn.Open();
                    string commandtxt = $"select * from Ansat where Ansattype = {ansattype};";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    a = new List<Ansat>();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Ansat ansat = new Ansat();
                        ansat.Id = (int)reader["AnsatId"];
                        ansat.Navn = (string)reader["Navn"];
                        ansat.Stelling = (string)reader["Stelling"];
                        ansat.Tlf = (string)reader["Tlf"];
                        a.Add(ansat);
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            return a;
        }

        public int HentAnsatId(string navn)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string commandtxt = $"select AnsatId from Ansat where Navn Like '%{navn}%';";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        id = (int)reader["AnsatId"];
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return id;
        }

        public string HentAnsatNavn(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string commandtxt = $"select Navn from Ansat where AnsatId= {id};";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return (string)reader["Navn"];
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return null;
        }

        public string OpretAnsat(Ansat a)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {

                try
                {
                    conn.Open();
                    string commandtxt = $"Insert into Ansat(Navn,Stelling,Tlf) values (@Navn,@Stelling,@Tlf)";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    command.Parameters.Add(new SqlParameter("@Navn", a.Navn));
                    command.Parameters.Add(new SqlParameter("@Stelling", a.Stelling));
                    command.Parameters.Add(new SqlParameter("@Tlf", a.Tlf));
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
            }
            return "Ansat blev oprettet!";
        }

        public string SletAnsat(int ansatId)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {

                try
                {
                    conn.Open();
                    string commandtxt = $"Delete from Ansat where AnsatId =@AnsatId";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    command.Parameters.Add(new SqlParameter("@AnsatId", ansatId));
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
            }
            return "Ansat blev slettet!";
        }

        public string UpdateAnsat(Ansat a)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {

                try
                {
                    conn.Open();
                    string commandtxt = "Update Ansat set Navn = @Navn, Stelling = @Stelling ,Tlf = @Tlf where AnsatId = @AnsatId ";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    command.Parameters.Add(new SqlParameter("@AnsatId", a.Id));
                    command.Parameters.Add(new SqlParameter("@Navn", a.Navn));
                    command.Parameters.Add(new SqlParameter("@Stelling", a.Stelling));
                    command.Parameters.Add(new SqlParameter("@Tlf", a.Tlf));
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
            }
            return "Ansat blev updatet!";
        }

        public List<Ansat> HentAlleBehandler()
        {
            List<Ansat> a = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {

                try
                {
                    conn.Open();
                    string commandtxt = $"select * from Ansat	where Stelling Not Like '%reciptionist%';";
                    SqlCommand command = new SqlCommand(commandtxt, conn);
                    a = new List<Ansat>();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Ansat ansat = new Ansat();
                        ansat.Id = (int)reader["AnsatId"];
                        ansat.Navn = (string)reader["Navn"];
                        ansat.Stelling = (string)reader["Stelling"];
                        ansat.Tlf = (string)reader["Tlf"];
                        a.Add(ansat);
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            return a;
        }

    }
}
