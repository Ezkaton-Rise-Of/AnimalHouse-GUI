using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using AnimalHouse_Entities;
using AnimalHouse_Entites;

namespace AnimalHouseDB
{
    class AnimalhouseDyrDatabase: IDyrDB
    {
        public AnimalhouseDyrDatabase()
        {
        }

        public string OpretDyr(Dyr d)
        {
            string result;
            SqlTransaction transaction = null;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Dyr (KundeId, Art, Race, Alder, sex) values (@KundeId, @Art, @Race, @Alder, @sex)");
                    command.Parameters.Add(new SqlParameter("@KundeId", d.KundeId));
                    command.Parameters.Add(new SqlParameter("@Race", d.Race));
                    command.Parameters.Add(new SqlParameter("@Alder", d.Alder));
                    command.Parameters.Add(new SqlParameter("@Race", d.Race));
                    command.Parameters.Add(new SqlParameter("@sex", d.Sex));
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    result = "Dyret er tilføjet";
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return Convert.ToString(e);
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
    }
}
