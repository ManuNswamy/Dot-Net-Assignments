using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBasedEntity;
namespace CodeBasedEntityConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var DeptObj = new DepartmentContext())
            {
                Console.WriteLine("Adding Department Details");
                var deptObj = new Department { Department_ID = 1, Department_Name = "IT", Department_Location = "Pune" };
                DeptObj.Department_Records.Add(deptObj);
                DeptObj.SaveChanges();
                Console.WriteLine("Record Inserted");
            }
            Console.ReadLine();
            
        }
    }
}
