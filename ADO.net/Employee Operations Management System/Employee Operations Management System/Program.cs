using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static string connectionString =
        "Data Source=LAPTOP-5RLHF38Q\\SQLEXPRESS01;Initial Catalog=Assignments;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

    static void Main()
    {
        Console.Write("Enter Department: ");
        string dept = Console.ReadLine();

        GetEmployeesByDepartment(dept);
        GetDepartmentEmployeeCount(dept);
        GetEmployeeOrders();
        GetDuplicateEmployees();

        Console.ReadLine();
    }

    static void GetEmployeesByDepartment(string dept)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_GetEmployeesByDepartment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Department", dept);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\nEmployees:");
            while (reader.Read())
            {
                Console.WriteLine($"{reader["EmpId"]} - {reader["Name"]} - {reader["Phone"]}");
            }
        }
    }

    static void GetDepartmentEmployeeCount(string dept)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_GetDepartmentEmployeeCount", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Department", dept);

            SqlParameter outputParam = new SqlParameter("@TotalEmployees", SqlDbType.Int);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine($"\nTotal employees in {dept}: {outputParam.Value}");
        }
    }

    static void GetEmployeeOrders()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_GetEmployeeOrders", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\nEmployee Orders:");
            while (reader.Read())
            {
                Console.WriteLine($"{reader["Name"]} - {reader["OrderAmount"]} - {reader["OrderDate"]}");
            }
        }
    }

    static void GetDuplicateEmployees()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_GetDuplicateEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\nDuplicate Employees:");
            while (reader.Read())
            {
                Console.WriteLine($"{reader["EmpId"]} - {reader["Name"]} - {reader["Phone"]}");
            }
        }
    }
}