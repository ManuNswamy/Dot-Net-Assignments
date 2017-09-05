using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace Assignment18_08
{
    class Employee: IComparable<Employee>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public string ProjectName { get; set; }
      
        public static List<Employee> EmployeeCollection = new List<Employee>();        
        static int key = 0;
        public void AddEmployee(int id, string name, string department_name, string project_name)
        {
            
            Console.WriteLine($"Adding Employee {name} in the system");
            ID = id;
            Name = name;
            DepartmentName = department_name;
            ProjectName = project_name;
            EmployeeCollection.Add(this);
         
            key++; 

        }
       
        public void display()
        {
            var query = from emp in EmployeeCollection
                        select emp.Name;
            Console.WriteLine("Name of the employee(s) in the system");
            foreach (var emp_name in query)
            {
                Console.WriteLine($"NAME:{emp_name}");
            }
            Console.WriteLine();
        }

        public void deleteRecord(string str)
        {
            int index = EmployeeCollection.FindIndex(a => a.Name == str);
            Console.WriteLine("After the remove operation");
            EmployeeCollection.RemoveAt(index);

        }
        public void updateName(string name_old, string name_new)
        {
            EmployeeCollection.First(d => d.Name == name_old).Name = name_new;

        }

        public int CompareTo(Employee other)
        {
            return ID.CompareTo(other.ID);
        }
        class SortOnName : IComparable<Employee>
        {
            public int CompareTo(Employee other)
            {
                throw new NotImplementedException();
            }
        }
    }

    class MyStringBuilder
    {
        char NullChar = '\0';
        int length = 0;
        static List<char> myStringBuilder = new List<char>();

        public void Append(char[] input)
        {
            foreach (var temp in input)
            {
                myStringBuilder.Add(temp);
                length++;
            }
        }
        public void AppendLine(char[] input)
        {
            myStringBuilder.Add('\0');
            length++;
            foreach (var temp in input)
            {
                myStringBuilder.Add(temp);
                length++;
            }
        }

        public void Replace(char charA, char charB)
        {

            if (myStringBuilder.Contains(charA))
            {
                int index = 0;
                for(index=0;index < length;index++)
                {
                    if(myStringBuilder[index]==charA)
                    {
                        myStringBuilder[index] = charB;
                    }
                }
            }  
        }
        public void display()
        {
            foreach(var x in myStringBuilder)
            {
                if (x == NullChar) Console.WriteLine();
                else Console.Write($"{x}");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //string phone_number= "123-1234";
            //phone_number.CheckPhoneNumber();
            //string str = "Test      Program   to remove   extra Spaces";       
            //str.RemoveExtraSpaces();

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            Employee emp4 = new Employee();
            Employee emp = new Employee();
            
            emp1.AddEmployee(123, "Subramani", "IT", "Artifical Intelligence");
            emp2.AddEmployee(124, "Harshada", "EXTC", "Networking");
            emp3.AddEmployee(125, "Anitha", "IT", "Natural Language Processing");
            emp4.AddEmployee(126, "Harshu", "Computers", "Game Programming");


            Console.WriteLine("Welcome To Employee Details System");
        back:
            Console.WriteLine("Enter 1.View All Records 2.Update Name 3.Remove Record 4.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1) goto display;
            if (choice == 2) goto update;
            if (choice == 3) goto remove;
            if (choice == 4) goto end;
            display:
            Employee.EmployeeCollection.Sort();
            emp.display();
            goto back;

        update:
            Console.WriteLine("Enter the current name of the employee");
            string old_name = Console.ReadLine();
            Console.WriteLine("Enter the new name of the employee");
            string new_name = Console.ReadLine();
            emp.updateName(old_name, new_name);
            Console.WriteLine("Updation performed successfully");
            Console.WriteLine();
            goto back;

        remove:
            Console.WriteLine("Enter the name of the employee to be removed");
            string toRemove = Console.ReadLine();
            emp.deleteRecord(toRemove);
            Console.WriteLine("Record removed successfully");
            Console.WriteLine();
            goto back;

        //MyStringBuilder str_bld = new MyStringBuilder();
        //string str1 = "This is some text";
        //string str2 = "This is next text";
        //char[] myString1 = str1.ToCharArray();
        //char[] myString2 = str2.ToCharArray();


        //str_bld.Append(myString1);
        //str_bld.Append(myString2);
        //str_bld.AppendLine(myString1);
        //str_bld.AppendLine(myString2);
        //str_bld.Append(myString1);
        //str_bld.Append(myString1);
        //str_bld.display();
        //str_bld.Replace('T', 'X');
        //str_bld.display();
        //goto end;

        end:
            Console.ReadLine();
            Console.WriteLine();
        }
        public void CollectionDemo()
        {
            
        }
    }

    static class Assignment 
    {
        public static void CheckPhoneNumber(this string str)
        {
            string pattern = @"^\d{3}-\d{4}$";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

            Match m = r.Match(str);

            if (m.Success)
            {
                Console.WriteLine($"Correct Format of telephone number {str}");
            }
            else
            {
                Console.WriteLine($"Incorrect Format of telephone number {str}");
            }
            Console.WriteLine();

        }

        public static void RemoveExtraSpaces(this string str)
        {
            Console.WriteLine($"Initial String : {str}");
            str = Regex.Replace(str, @"\s+", " ");
            Console.WriteLine($"Removing Extra Spaces : {str}");
            Console.WriteLine();
        }

      
    }
   


}
