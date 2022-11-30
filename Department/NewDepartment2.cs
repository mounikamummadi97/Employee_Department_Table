using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    internal class NewDepartment2
    {
        string connection;
        SqlConnection con;
        string query;
        public void UpdateDepartment()
        {
            Console.WriteLine("Enter DeptID where to Update ");
            int DeptID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Updated Department Name");
            string DeptName = Console.ReadLine();



            connection = "Server=LAPTOP-0ELAKBQI\\SQLEXPRESS;Database=Mounika;Trusted_Connection=true";
            con = new SqlConnection(connection);
            con.Open();
            query = "update Department set DeptName='" + DeptName + "' where DeptID=" + DeptID + "";
            SqlCommand cmd = new SqlCommand(query, con);
            
            int objDone = cmd.ExecuteNonQuery();
            con.Close();
            if (objDone == 1)
            {
                Console.WriteLine("Updated Record");
            }

        }
        public void DeleteDepartment()
        {
            Console.WriteLine("Enter Department ID  to Delete ");
            int deptId = int.Parse(Console.ReadLine());
            connection = "Server=LAPTOP-0ELAKBQI\\SQLEXPRESS;Database=Mounika;Trusted_Connection=true";
            con = new SqlConnection(connection);
            con.Open();
            query = "delete Department where DeptID=" + deptId + "";
            SqlCommand cmd = new SqlCommand(query, con);
            int objDone = cmd.ExecuteNonQuery();
            cmd.Clone();
            if (objDone == 1)
            {
                Console.WriteLine("Department Record Deleted Successfully");
            }
        }
    }
}

