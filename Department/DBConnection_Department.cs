using DBConnectionProject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Department
{
    internal class DBConnection_Department : DepartmentList
    {
        SqlConnection con;
        SqlCommand cmd;
        string conStr = "";
        public DBConnection_Department()
        {
            try
            {
                conStr = DBConnections.conStr;
            }
            catch (System.Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
        }
        private SqlConnection DBConnection(string query)
        {
            con = new SqlConnection(conStr);
            return con;
        }

        public string InsertDepartmentDataIntoDB(string  query)
        {
            //connetionString = "Server=LAPTOP-0ELAKBQI\\SQLEXPRESS;Database=Mounika;Trusted_Connection=true;";
            //query = "Insert into Department Values()";
            //SqlCon.Open();
            //SqlCon.Close();
            bool isDataInserted = true;
            DepartmentList departmentListobj = new DepartmentList();
            var departmentList = departmentListobj.Method();
            //var Deptlist = Method();

            //SqlConnection connectionstring = new SqlConnection("Server=LAPTOP-0ELAKBQI\\SQLEXPRESS;Database=Mounika;Trusted_Connection=true;");
            //string query = "Insert Into Department (DeptName, DeptShortName) " +
            //                   "VALUES (@DN, @SN) ";
            foreach (var dept in departmentList)
            {
                DBConnection(query);
                cmd = new SqlCommand(query, con);
                

                // add parameters and their values
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@DN", System.Data.SqlDbType.NVarChar, 100).Value = dept.DeptName;
                cmd.Parameters.Add("@SN", System.Data.SqlDbType.NVarChar, 100).Value = dept.DeptShortName;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            return isDataInserted == true ? "Success" : "Falied";

        }
        List<DBConnection_Department> newList = new List<DBConnection_Department>();
        public string SelectEmployeeDataToNewList(string query)
        {
            bool isDataSelected = true;
            DBConnection(query);
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    newList.Add(new DBConnection_Department()
                    {
                        DeptID = (int)dr["DeptID"],
                        DeptName = dr["DeptName"].ToString(),
                        DeptShortName = dr["DeptShortName"].ToString()

                    });
                }
            }
            con.Close();
            return isDataSelected == true ? "Successfully Selected From DataBase" : "No Data Selected";
        }
        public void DisplayNewList()
        {
            foreach (var item in newList)
            {
                Console.WriteLine("Department ID : " + item.DeptID);
                Console.WriteLine("Department Name : " + item.DeptName);
                Console.WriteLine("Department ShortName : " + item.DeptShortName);




                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
