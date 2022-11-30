using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employee
{
    internal class NewEmployee : EmployeeProperties

    {
      
        string connection;
        SqlConnection con;
        string query;
        public void UpadteEmployee()
        {
            Console.WriteLine("Enter EmployeeID where to Update ");
            int empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Updated Employee Name");
            string empName = Console.ReadLine();



            connection = "Server=LAPTOP-0ELAKBQI\\SQLEXPRESS;Database=Mounika;Trusted_Connection=true";
            con = new SqlConnection(connection);
            con.Open();
            query = "update Employe set EmpName='" + empName + "' where EmpID=" + empId + "";
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.Add("@EmpName", System.Data.SqlDbType.NVarChar, 100).Value = eName;
            int objDone = cmd.ExecuteNonQuery();
            cmd.Clone();
            if (objDone == 1)
            {
                Console.WriteLine("Updated Record");
            }

        }
        public void DeleteEmployee()
        {
            Console.WriteLine("Enter EmployeeID  to Delete ");
            int eId = int.Parse(Console.ReadLine());



            con = new SqlConnection(connection);
            con.Open();
            query = "delete Employee where EmpID=" + eId + "";
            SqlCommand cmd = new SqlCommand(query, con);
            int objDone = cmd.ExecuteNonQuery();
            cmd.Clone();
            if (objDone == 1)
            {
                Console.WriteLine("Employee Record Deleted Successfully");
            }
        }
    }
}
