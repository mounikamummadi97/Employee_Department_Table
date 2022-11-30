using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmployeeLists : EmployeeProperties
    {
        public List<EmployeeLists> Method()
        {
            List<EmployeeLists> employeeLists = new List<EmployeeLists>
            {
                new EmployeeLists { EmpName = "Mounika", EmpAge = 20,EmpGender="F",DeptID=1 },
                new EmployeeLists { EmpName = "Vinay", EmpAge = 22,EmpGender="M",DeptID=2 },
                new EmployeeLists { EmpName = "Durga", EmpAge = 25,EmpGender="F",DeptID=3},
                new EmployeeLists { EmpName = "Shravan", EmpAge = 30,EmpGender="M",DeptID=4 },
                new EmployeeLists { EmpName = "Shilpa", EmpAge = 21,EmpGender="F",DeptID=5}
            };
            return employeeLists;

        }
    }
}
