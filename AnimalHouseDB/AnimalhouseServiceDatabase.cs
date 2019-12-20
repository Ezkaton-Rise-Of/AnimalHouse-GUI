//Holger
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

        public List<Service> HentAlleServiceByServiceType(Servicetype servicetype)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString)) {  

                List<Service> ld = null;
                SqlTransaction transaction = null;


                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("Select * from Service " +
                        "left join ServiceType on Service.ServiceTypeId = ServiceType.ServiceTypeId " +
                        "Left Join Produkt on Produkt.ProduktId = Service.ProduktId where Service.ServiceTypeId = @ServiceType; ", conn);
                    command.Parameters.Add(new SqlParameter("@Servicetype", servicetype.ServiceTypeId));

                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    ld = new List<Service>();
                    while (reader.Read())
                    {
                        Service service = new Service();
                        Servicetype serviceType = new Servicetype(Convert.ToString(reader["ServiceType"]), Convert.ToInt32(reader["ServiceTypeId"]));
                        service.Servicetype = serviceType;
                        service.ProduktId = Convert.ToInt32(reader["ProduktId"]);
                        service.Navn = Convert.ToString(reader["Navn"]);
                        ld.Add(service);
                    }
                    reader.Close();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
                finally
                {
                    conn.Close();
                }


                return ld;
            }
        
        }

        public List<Servicetype> HentAlleServiceType()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString)) { 

                List<Servicetype> ld = null;
                SqlTransaction transaction = null;
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand("Select * from ServiceType", conn);
                    command.Transaction = transaction;
                    SqlDataReader reader = command.ExecuteReader();
                    ld = new List<Servicetype>();
                    while (reader.Read())
                    {
                        Servicetype servicetype = new Servicetype(Convert.ToString(reader["ServiceType"]), Convert.ToInt32(reader["ServiceTypeId"]));
                        ld.Add(servicetype);
                    }
                    reader.Close();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
                finally
                {
                    conn.Close();

                }
                return ld;
            }
        }
    }


    
}
