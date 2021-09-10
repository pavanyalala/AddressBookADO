using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookADO.Net
{
    public class AddressBookDetails
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBookServiceADO";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        public int choice;

        public void AddEmployee()
        {
            SqlCommand command = new SqlCommand("spInsertRecord", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            Console.Write("Enter First Name :");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name :");
            string lastName = Console.ReadLine();
            Console.Write("Enter Address :");
            string address = Console.ReadLine();
            Console.Write("Enter City :");
            string city = Console.ReadLine();
            Console.Write("Enter State :");
            string state = Console.ReadLine();
            Console.Write("Enter Zip code :");
            double zip = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Mobile :");
            double phoneNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Email :");
            string email = Console.ReadLine();
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@State", state);
            command.Parameters.AddWithValue("@Zip", zip);
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@Email", email);

            sqlConnection.Open();
            int i = command.ExecuteNonQuery();
            sqlConnection.Close();
            if (i >= 1)
            {
                Console.WriteLine("Data inserted sucessfully");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
        public void DisplayEmployee()
        {

            while (choice != 5)
            {
                Console.WriteLine("\n Enter 1 for Add Address Record" +
                    "\n Enter 5 for Exit");
                Console.WriteLine(" Enter Your Choice ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }
        }
    }
}
