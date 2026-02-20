using System;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

public class Program
{
    static string connectionString = "Data Source=.;Initial Catalog=EmployeeDB;Integrated Security=True;TrustServerCertificate=True";
    public static void AddEmployee()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be empty");
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
        }

        Console.Write("Enter Salary: ");
        decimal salary;
        while (!decimal.TryParse(Console.ReadLine(), out salary) || salary < 0)
        {
            Console.WriteLine("Invalid salary. Please enter a valid positive number");
            Console.WriteLine("Enter salary: ");
        }

        Console.Write("Enter Department: ");
        string dept = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(dept))
        {
            Console.WriteLine("Department cannot be empty.");
            Console.Write("Enter Department: ");
            dept = Console.ReadLine();
        }

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "insert into Employees (Name, Salary, Department) values (@Name, @Salary, @Dept)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@Dept", dept);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("Employee Added Successfully");
        }
    }
    public static void ViewEmployees()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "select * from Employees";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                Console.WriteLine("No Employees found in database");
                return;
            }

            while (reader.Read())
            {
                Console.WriteLine(
                    reader["Id"] + " | " + reader["Name"] + " | " + reader["Salary"] + " | " + reader["Department"]);
            }
        }
    }
    public static void UpdateEmployee()
    {
        Console.Write("Enter Employee Id: ");
        int id;
        while(!int.TryParse(Console.ReadLine(), out id) || id < 0)
        {
            Console.WriteLine("Invalid Id. Please enter a valid positive number.");
            Console.Write("Enter Employee Id: ");
        }

        Console.Write("Enter Salary: ");
        decimal salary;
        while(!decimal.TryParse(Console.ReadLine(), out salary) || salary < 0)
        {
            Console.WriteLine("Invalid salary. Please enter a valid positive number");
            Console.Write("Enter salary: ");
        }

        using(SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "update Employees set Salary=@Salary where Id=@Id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("Employee Updated Successfully");
        }
    }
    public static void DeleteEmployee()
    {
        Console.Write("Enter Employee Id: ");
        int id;
        while(!int.TryParse(Console.ReadLine(), out id) || id < 0)
        {
            Console.WriteLine("Invalid Id. Please enter a valid positive number.");
            Console.Write("Enter Employee Id: ");
        }

        using(SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "delete from Employees where Id=@Id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("Employee Deleted Successfully");
        }
    }
    public static void Main()
    {
        bool check = true;
        while (check)
        {
            Console.WriteLine("\n1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. Exit");

            Console.Write("Enter choice: ");
            int choice;
            if(!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid Input. Please enter a number");
                return;
            }


            switch (choice)
            {
                case 1:
                    AddEmployee();
                    break;
                case 2:
                    ViewEmployees();
                    break;
                case 3:
                    UpdateEmployee();
                    break;
                case 4:
                    DeleteEmployee();
                    break;
                case 5:
                    check = false;
                    return;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}