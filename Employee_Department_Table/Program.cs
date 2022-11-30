//using Department;
//using Employee_Department_Table;

//https://aka.ms/new-console-template for more information

using Employee;
using Department;
int item = 0;
Console.WriteLine("press 1 for Department table ");
Console.WriteLine("press 2 for EmployeeTable ");
item = int.Parse(Console.ReadLine());
switch (item) { 
    case 1:
        Console.WriteLine("Execute Department table");
        ExecutableClass objExecutableClass = new ExecutableClass();
        objExecutableClass.DepartmentExecution();

        break;
    case 2:
        Console.WriteLine("Execute EmployeeTable");
       
        ExecutableClass2 objExecutableClass1 = new ExecutableClass2();

        objExecutableClass1.ExecutableEmployee();
        break;
}
