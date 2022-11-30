using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    public class DepartmentList : Properties
    {
        public List<DepartmentList> Method()
        {           
            List<DepartmentList> departmentLists = new List<DepartmentList>
            {
                new DepartmentList { DeptID = 101, DeptName = "InformationTechnology", DeptShortName = "IT" },
                new DepartmentList { DeptID = 102, DeptName = "HumanResource", DeptShortName = "HR" },
                new DepartmentList { DeptID = 103, DeptName = "HealthDepartment", DeptShortName = "HD" },             
                new DepartmentList { DeptID = 104, DeptName = "ElectricityDepartment", DeptShortName = "ED" },
                new DepartmentList { DeptID = 105, DeptName = "FinanceDepartment", DeptShortName = "FD" }
            };           
            return departmentLists;            
        }
    }
}
    

