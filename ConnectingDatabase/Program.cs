using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Configuration;

namespace ConnectingDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = @"data source=DESKTOP-TIC5DM4\SQLEXPRESS;Initial Catalog=Programdb;Integrated Security=SSPI;";
            string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
               // connection.Open();
                
                try
                {
                    connection.Open();
                     using( SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("Tables in the database:");
                            while (reader.Read())
                            {
                                Console.WriteLine(reader["TABLE_NAME"].ToString());
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred"+ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                
            }

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        
        
        
        }
    }
}
