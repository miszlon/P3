using System;
using System.Data.SqlClient;


namespace P4_LAB1_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = "Server = .\\NewDB2;Database = Northwind; Trusted_Connection = True";

            using (var connection = new SqlConnection(conStr))
            {
                
                var command = new SqlCommand
                    (
                    cmdText: "insert into Employees(FirstName, LastName) values(@firstName, @lastName)", connection
                    );

                command.Parameters.AddRange(values: new[]
                {
                    new SqlParameter("firstName", value:"Jan"),
                    new SqlParameter("lastName", value :"Kowalski")
                });
              
                command.Connection.Open();

                command.ExecuteNonQuery();

                var reader = command.ExecuteReader();

                //while (reader.Read())
                //{
                //    Console.WriteLine("{0} {1}", reader[0], reader[1]);
                //}
            }
        }
    }
}
