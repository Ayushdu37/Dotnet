using System;
using System.Data.SqlClient; // Use Microsoft.Data.SqlClient for modern .NET
using System.Data;
using System.Reflection.PortableExecutable;

//class Program
//{
//    static void Main()
//    {
//        // 1. Define the connection string
//        // Replace [ServerName] and [DatabaseName] with your actual SQL Server details.
//        // Use "Trusted_Connection=True" for Windows Authentication (integrated security)
//        // or "User Id=myUsername;Password=myPassword;" for SQL Server Authentication.
//        string connectionString = "Data Source=RITIKPC\\SQLEXPRESS;" +
//            "initial catalog=collage;Integrated Security=True;Connect Timeout=30;" +
//            "Encrypt=True;TrustServerCertificate=True;";

//        // 2. Create a SqlConnection object within a 'using' statement
//        // The 'using' statement ensures the connection is automatically closed and disposed
//        // even if errors occur.
//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            try
//            {
//                string dpet = "cse";
//                //int id = 1;
//                // 3. Open the connection
//                connection.Open();
//                Console.WriteLine("Connection successful!");

//                // 4. Define and execute a SQL command
//                string query = "SELECT Name,Department from CollageMaster where Department=@dpet";
//                //string query = "SELECT Name,Department from CollageMaster where Id=@id";

//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    // addwithvalue 
//                    command.Parameters.AddWithValue("@dpet", dpet);
//                    //command.Parameters.AddWithValue("@Id",id);
//                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
//                    // Use parameters to prevent SQL injection
//                    SqlCommandBuilder sqlee = new SqlCommandBuilder(dataAdapter);



//                    // Use SqlDataReader to read data from the database
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        Console.WriteLine("\nReading data...");
//                        while (reader.Read())
//                        {
//                            // Access data by column name or index
//                            Console.WriteLine($"{reader["Name"]} {reader["Department"]}");
//                        }
//                    }
//                }
//            }
//            catch (SqlException ex)
//            {
//                // Handle any errors that may occur during the connection or query
//                Console.WriteLine($"Error: {ex.Message}");
//            }
//            // The connection is implicitly closed when the 'using' block ends (even in case of error)
//            Console.WriteLine("Connection closed.");
//            Hyy();
//        }


//    }

//    private static void Hyy()
//    {
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // 1. Define the connection string
//        // Replace [ServerName] and [DatabaseName] with your actual SQL Server details.
//        // Use "Trusted_Connection=True" for Windows Authentication (integrated security)
//        // or "User Id=myUsername;Password=myPassword;" for SQL Server Authentication.
//        string connectionString = "Data Source=LAPTOP-5RLHF38Q\\SQLEXPRESS;" +
//            "initial catalog=College;Integrated Security=True;Connect Timeout=30;" +
//            "Encrypt=True;TrustServerCertificate=True;";

//        // 2. Create a SqlConnection object within a 'using' statement
//        // The 'using' statement ensures the connection is automatically closed and disposed
//        // even if errors occur.
//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            try
//            {


//                // 3. Open the connection
//                connection.Open();
//                Console.WriteLine("Connection successful!");

//                // 4. Define and execute a SQL command

//                // Stored Procdure name
//                using (SqlCommand command = new SqlCommand("sp_getStudentDetails", connection))
//                {

//                    command.CommandType = CommandType.StoredProcedure;
//                    //command.Parameters.AddWithValue("@Id",id);
//                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
//                    // Use parameters to prevent SQL injection
//                    SqlCommandBuilder sqlee = new SqlCommandBuilder(dataAdapter);



//                    // Use SqlDataReader to read data from the database
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        Console.WriteLine("\nReading data...");
//                        while (reader.Read())
//                        {
//                            // Access data by column name or index
//                            Console.WriteLine($"{reader[0]} {reader[1]}");
//                        }
//                    }
//                }
//            }
//            catch (SqlException ex)
//            {
//                // Handle any errors that may occur during the connection or query
//                Console.WriteLine($"Error: {ex.Message}");
//            }
//            // The connection is implicitly closed when the 'using' block ends (even in case of error)
//            Console.WriteLine("Connection closed.");
//            Hyy();
//        }


//    }

//    private static void Hyy()
//    {
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // 1. Define the connection string
//        // Replace [ServerName] and [DatabaseName] with your actual SQL Server details.
//        // Use "Trusted_Connection=True" for Windows Authentication (integrated security)
//        // or "User Id=myUsername;Password=myPassword;" for SQL Server Authentication.
//        string connectionString = "Data Source=LAPTOP-5RLHF38Q\\SQLEXPRESS;" +
//            "initial catalog=College;Integrated Security=True;Connect Timeout=30;" +
//            "Encrypt=True;TrustServerCertificate=True;";

//        // 2. Create a SqlConnection object within a 'using' statement
//        // The 'using' statement ensures the connection is automatically closed and disposed
//        // even if errors occur.
//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            try
//            {


//                // 3. Open the connection
//                connection.Open();
//                Console.WriteLine("Connection successful!");

//                char gender = 'M';
//                string dept = "CSE";

//                // 4. Define and execute a SQL command

//                // Stored Procdure name
//                using (SqlCommand command = new SqlCommand("sp_getStudentDetailsWithParameters", connection))
//                {

//                    command.CommandType = CommandType.StoredProcedure;
//                    command.Parameters.AddWithValue("@gender" ,gender);
//                    command.Parameters.AddWithValue("@dept", dept);

//                    //command.Parameters.AddWithValue("@Id",id);
//                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
//                    // Use parameters to prevent SQL injection
//                    SqlCommandBuilder sqlee = new SqlCommandBuilder(dataAdapter);



//                    // Use SqlDataReader to read data from the database
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        Console.WriteLine("\nReading data...");
//                        while (reader.Read())
//                        {
//                            // Access data by column name or index
//                            Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]}");
//                        }
//                    }
//                }
//            }
//            catch (SqlException ex)
//            {
//                // Handle any errors that may occur during the connection or query
//                Console.WriteLine($"Error: {ex.Message}");
//            }
//            // The connection is implicitly closed when the 'using' block ends (even in case of error)
//            Console.WriteLine("Connection closed.");
//            Hyy();
//        }


//    }

//    private static void Hyy()
//    {
//    }
//}

class Program
{
    static void Main()
    {
        // 1. Define the connection string
        // Replace [ServerName] and [DatabaseName] with your actual SQL Server details.
        // Use "Trusted_Connection=True" for Windows Authentication (integrated security)
        // or "User Id=myUsername;Password=myPassword;" for SQL Server Authentication.
        string connectionString = "Data Source=10.62.235.135;" +
            "initial catalog=College;Integrated Security=True;Connect Timeout=30;" +
            "Encrypt=True;TrustServerCertificate=True;";

        // 2. Create a SqlConnection object within a 'using' statement
        // The 'using' statement ensures the connection is automatically closed and disposed
        // even if errors occur.
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {


                // 3. Open the connection
                connection.Open();
                Console.WriteLine("Connection successful!");

                //char gender = 'M';
                //string dept = "CSE";

                // 4. Define and execute a SQL command

                // Stored Procdure name
                using (SqlCommand command = new SqlCommand("sp_getStudentDetailWithInputAndOutputParameters", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@gender", 'M');
                    SqlParameter output = new SqlParameter();
                    output.ParameterName = "@TotalCount";
                    output.SqlDbType = SqlDbType.Int;
                    output.Direction = ParameterDirection.Output;

                    command.Parameters.Add(output);

                    command.ExecuteNonQuery();

                    int TotalCount = Convert.ToInt32(output.Value);
                    Console.WriteLine($"Total Male Count: {TotalCount}");


                    //command.Parameters.AddWithValue("@Id",id);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    // Use parameters to prevent SQL injection
                    SqlCommandBuilder sqlee = new SqlCommandBuilder(dataAdapter);



                    // Use SqlDataReader to read data from the database
                    //using (SqlDataReader reader = command.ExecuteReader())
                    //{
                    //    Console.WriteLine("\nReading data...");
                    //    while (reader.Read())
                    //    {
                    //        // Access data by column name or index
                    //        Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]}");
                    //    }
                    //}
                }
            }
            catch (SqlException ex)
            {
                // Handle any errors that may occur during the connection or query
                Console.WriteLine($"Error: {ex.Message}");
            }
            // The connection is implicitly closed when the 'using' block ends (even in case of error)
            Console.WriteLine("Connection closed.");
            Hyy();
        }


    }

    private static void Hyy()
    {
    }
}