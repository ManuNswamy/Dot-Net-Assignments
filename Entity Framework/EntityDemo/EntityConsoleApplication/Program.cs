using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDemo;

namespace EntityConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var EmpObj = new EmployeesEntities())
            {
                var emp = new Table_Employees();
                emp.Emp_ID = 1;
                emp.Emp_Name = "Manu";
                emp.Emp_Salary = 1200;
                EmpObj.Table_Employees.Add(emp);
                EmpObj.SaveChanges();
                Console.WriteLine("Record Inserted");
            }
            Console.ReadLine();
        }
    }
}
