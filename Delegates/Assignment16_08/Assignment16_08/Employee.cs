using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16_08
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public string ProjectName { get; set; }
        static List<Employee> EmployeeCollection = new List<Employee>();

        public void AddEmployee(int id,string name,string department_name,string project_name)
        {
            ID = id;
            Name = name;
            DepartmentName = department_name;
            ProjectName = project_name;
            EmployeeCollection.Add(this);
        }

        public void display()
        {
            var query = from emp in EmployeeCollection
                        select emp.Name;
            Console.WriteLine("Select only employee name");
            foreach(var emp_name in query)
            {
                Console.WriteLine($"NAME:{emp_name}");
            }

            Console.WriteLine();
            query = from emp in EmployeeCollection
                    where emp.DepartmentName == "IT"
                    select emp.Name;
            Console.WriteLine("Select only employee name where Department Name is IT");
            foreach (var emp_name in query)
            {
                Console.WriteLine($"NAME:{emp_name}");
            }
            Console.WriteLine();
            var resultList = EmployeeCollection.Any(n => n.Name == "Harshada");
            Console.WriteLine("Does the EmployeeCollection contains Employee Harshada ?");
            Console.WriteLine(resultList);

        }
           


        }



    
}

