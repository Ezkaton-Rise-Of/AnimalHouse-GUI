using System;
using System.Configuration;
using System.Data.SqlClient;

namespace AnimalHouseDB
{
    public class AnimalHouseDataBase
    {

        protected SqlConnection GetConnString()
        {
            return new SqlConnection( ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }
        protected bool OpenDataBase(SqlConnection conn)
        {
            try
            {
                conn.Open();
                return true;
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

        protected SqlCommand PrepareSql(string sqlstring, SqlConnection conn)
        {


            return new SqlCommand(sqlstring, conn);
        }

        protected void ExecuteSql(string sqlstring)
        {
            SqlConnection conn = GetConnString();
            {
                SqlCommand command = PrepareSql("", conn);
                if (OpenDataBase(conn))
                    try
                    {
                        command.ExecuteNonQuery();
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
        }
    }
}
