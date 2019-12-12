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
    public class AnimalhouseServiceDatabase : IServiceDB
    {
        public AnimalhouseServiceDatabase()
        {
        }

        public List<Service> HentAlleService()
        {
            List<Service> ld = null;
            SqlTransaction transaction = null;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            conn.Open();
            transaction = conn.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand("Select * from Service left join ServiceType on Service.ServiceTypeId = ServiceType.ServiceTypeId;", conn);
                command.Transaction = transaction;
                SqlDataReader reader = command.ExecuteReader();
                ld = new List<Service>();
                while (reader.Read())
                {
                    Service d = new Service();
                    d.ServiceType = Convert.ToString(reader["ServiceType"]);
                    ld.Add(d);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conn.Close();
            }


            return ld;
        }

        public List<Service> HentAlleServiceType()
        {
            throw new NotImplementedException();
        }

        public Service HentService(int s)
        {
            throw new NotImplementedException();
        }

        public bool OpretService(Service s)
        {
            throw new NotImplementedException();
        }

        public bool SletService(int s)
        {
            throw new NotImplementedException();
        }

        public bool UpdateService(Service s)
        {
            throw new NotImplementedException();
        }
    }
}
