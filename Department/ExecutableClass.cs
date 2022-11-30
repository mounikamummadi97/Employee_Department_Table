using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    public class ExecutableClass
    {
        public void DepartmentExecution()
        {
            DBConnection_Department objDBConnection = new DBConnection_Department();
            objDBConnection.InsertDepartmentDataIntoDB("Insert Into Department (DeptName, DeptShortName) " +
                               "VALUES (@DN, @SN)");
            DBConnection_Department objDBConnection1 = new DBConnection_Department();
            objDBConnection1.SelectEmployeeDataToNewList("select * From Department");
            objDBConnection1.DisplayNewList();

            NewDepartment objNewDepartment = new NewDepartment();
           //bjNewDepartment.AddDepartment();
            // objNewDepartment.SelectEmployeeDataToNewList("SELECT * from Department");
            NewDepartment2 objNewDepartment2 = new NewDepartment2();
            objNewDepartment2.UpdateDepartment();
            NewDepartment2 objNewDepartment3 = new NewDepartment2();
            objNewDepartment3.DeleteDepartment();
            GetNewDeparmentList objGetNewDeparmentList = new GetNewDeparmentList();
            objGetNewDeparmentList.List();

        }
        
    }
}
