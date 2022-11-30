using DBConnectionProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class DBConnection : EmployeeLists
    {
        SqlConnection con;
        SqlCommand cmd;
        string conStr = "";
        public DBConnection()
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
        //private int EstablishingDbConnection(Query)
        //public getDataMethod(query)//establish db connection and execute query and get return type
        //public setdatamethod(query)
        private SqlConnection DBConnection1(string query)
        {
            con = new SqlConnection(conStr);
            return con;
        }
        public string InsertEmployeeDataIntoDB(string query)
        {
            bool isDataInserted = true;
            //EmployeeLists employeeListobj = new EmployeeLists();
            //var employeeLists = employeeListobj.Method();
            var Emplist = Method();
            foreach (var dept in Emplist)
            {
                DBConnection1(query);
                cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add("@EmpName", System.Data.SqlDbType.NVarChar, 100).Value = dept.EmpName;
                cmd.Parameters.Add("@EmpAge", System.Data.SqlDbType.NVarChar, 100).Value = dept.EmpAge;
                cmd.Parameters.Add("@Gender", System.Data.SqlDbType.NVarChar, 100).Value = dept.EmpGender;
                cmd.Parameters.Add("@DeptID", System.Data.SqlDbType.NVarChar, 100).Value = dept.DeptID;
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    isDataInserted = false;
                    break;
                }
                con.Close();
            }
            return isDataInserted == true ? "Success" : "Falied";
        }
        List<DBConnection> newList = new List<DBConnection>();
        public string SelectEmployeeDataToNewList(string query)
        {
            bool isDataSelected = true;
            DBConnection1(query);
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    newList.Add(new DBConnection()
                    {
                        EmpID = (int)dr["EmpID"], 
                        EmpName = dr["EmpName"].ToString(),
                        EmpAge = (int)dr["EmpAge"],
                        EmpGender = dr["EmpGender"].ToString(),
                        DeptID = (int)dr["DeptID"]
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
                Console.WriteLine("Employee ID : " + item.EmpID);
                Console.WriteLine("Employee Name : " + item.EmpName);
                Console.WriteLine("Employee Age : " + item.EmpAge);
                Console.WriteLine("Employee Gender : " + item.EmpGender);
                Console.WriteLine("Employee Dept ID : " + item.DeptID);
                Console.WriteLine("*************************************************");
            }
        }



    }
}

