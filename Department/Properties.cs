using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    public class Properties
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public string DeptShortName { get; set; }
        public void Display()
        {
            Console.WriteLine("Enter Department ID");
            this.DeptID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Department Name");
            this.DeptName = Console.ReadLine();

            Console.WriteLine("Enter Department ShortName ");
            this.DeptShortName = Console.ReadLine();



        }

        public void ShowDepartment()
        {
            Console.WriteLine("Department ID : {0}" + Environment.NewLine + "Department Name : {1}" + Environment.NewLine + "DeptShortName : {2}",
                this.DeptID, this.DeptName, this.DeptShortName);
        }
    }

}
