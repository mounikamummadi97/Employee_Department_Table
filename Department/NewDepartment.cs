using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    internal class NewDepartment
    {
        string connection;
        SqlConnection con;
        string query;
        public void AddDepartment()
        {
            Console.WriteLine("Enter Department Name ");
            string DName = Console.ReadLine();
            Console.WriteLine("Enter Department Short Name");
            string DShortName = Console.ReadLine();



            connection = "Server=LAPTOP-0ELAKBQI\\SQLEXPRESS;Database=Mounika;Trusted_Connection=true";
            con = new SqlConnection(connection);
            con.Open();
            query = "insert into Department values('" + DName + "','" + DShortName + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            int isDone = cmd.ExecuteNonQuery();
            con.Close();
            if (isDone == 1)
            {
                Console.WriteLine("Department Record inserted Successfully");
            }
        }
    }
}

