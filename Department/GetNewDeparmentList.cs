using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Department;
namespace Department
{
    public class GetNewDeparmentList : Properties
    {
        SqlConnection con;
        string query;
        List<GetNewDeparmentList> Departmentlist = new List<GetNewDeparmentList>();
        public void List()
        {

            SqlConnection con = new SqlConnection("Server=LAPTOP-0ELAKBQI\\SQLEXPRESS;Database=Mounika;Trusted_Connection=true");


            SqlCommand command = new SqlCommand("SELECT * FROM Department", con);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                Departmentlist.Add(new GetNewDeparmentList()
                {
                    DeptID = (int)reader["DeptID"],
                    DeptName = (string)reader["DeptName"],
                    DeptShortName = (string)reader["DeptShortName"]

                });
                Console.WriteLine();
            }
            foreach (var item in Departmentlist)
            {
                Console.WriteLine("Department ID : " + item.DeptID);
                Console.WriteLine("Department Name:" + item.DeptName);
                Console.WriteLine("Department ShortName:" + item.DeptShortName);
            }

            con.Close();
        }



        public void Insert()
        {
            GetNewDeparmentList objDepartment;


            Console.WriteLine("How Many Departments, Do you want add?");
            int Count = int.Parse(Console.ReadLine());
            for (int loopVariable = 1; loopVariable <= Count; loopVariable++)
            {
                objDepartment = new GetNewDeparmentList();

                objDepartment.Display();
                Departmentlist.Add(objDepartment);

            }
            Console.WriteLine("****************** Department List ******************");
            foreach (GetNewDeparmentList item in Departmentlist)
            {
                item.ShowDepartment();
            }
        }
    }
}
