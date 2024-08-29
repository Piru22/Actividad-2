using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Actividad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=localhost;" +
                "initial catalog=Actividad 2;" +
                "Integrated Security = true;";

            String query = "SELECT * FROM Profesores";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0},{1},{2},{3},{4}",
                        reader[0], reader[1], reader[2], reader[13], reader[4]);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}









        
            
        