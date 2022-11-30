using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class ExecutableClass2
    {
        public void ExecutableEmployee()
        {
            DBConnection objDBConnection = new DBConnection();
            objDBConnection.InsertEmployeeDataIntoDB("Insert Into Employe (EmpName, EmpAge,EmpGender,DeptID) VALUES(@EmpName,@EmpAge,@Gender,@DeptID)");
            objDBConnection.SelectEmployeeDataToNewList("select * From Employe");
            objDBConnection.DisplayNewList();

            NewEmployee objNewEmployee = new NewEmployee();
            objNewEmployee.UpadteEmployee();
            //NewEmployee objNewEmployee1 = new NewEmployee();
            objNewEmployee.DeleteEmployee();
            Employee_NewList_FromDatabase objEmployee_NewList_FromDatabase = new Employee_NewList_FromDatabase();

            objEmployee_NewList_FromDatabase.EmployeeNewList();
            objEmployee_NewList_FromDatabase.DisplayNewList();
        }
        
    }
}
