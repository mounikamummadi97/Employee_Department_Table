using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;

namespace Employee
{
    public class Employee_NewList_FromDatabase : EmployeeProperties
    {
        string connection;
        SqlConnection con;
        string query;
        List<Employee_NewList_FromDatabase> newList = new List<Employee_NewList_FromDatabase>();
        public void EmployeeNewList()
        {
            connection = "Server=LAPTOP-0ELAKBQI\\SQLEXPRESS;Database=Mounika;Trusted_Connection=true;";
            con = new SqlConnection(connection);
            query = "Select * from Employee";
            con.Open();
            
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            //SqlDataAdapter da = new SqlDataAdapter(query, con);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Employee");



            //da.Fill(ds, "Employee");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    newList.Add(new Employee_NewList_FromDatabase()
                    {
                        EmpID = (int)dr["EmpID"],
                        EmpName = dr["EmpName"].ToString(),
                        EmpAge = (int)dr["EmpAge"],
                        EmpGender = dr["Gender"].ToString(),
                        DeptID = (int)dr["DeptID"]
                       
                    });
                }
                con.Close();
            }
        }
        public void DisplayNewList()
        {
            foreach (var item in newList)
            {
                Console.WriteLine("Employee ID : " + item.EmpID);
                Console.WriteLine("Employee Name : " + item.EmpName);
                Console.WriteLine("Employee Age : " + item.EmpAge);
                Console.WriteLine("Employee Gender : " + item.EmpGender);
                Console.WriteLine("Employee Dept ID : " + item.DeptID);
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
