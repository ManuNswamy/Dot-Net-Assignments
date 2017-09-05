using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var student = new Student();
                student.GetDataSet();
                student.UpdateDataSet();
                student.GetDataSet();
                //student.SaveData();
            }
            catch (Exception e)
            {

                Console.WriteLine($"Exception : {e}");
            }
            Console.ReadLine();
           

        }
    }
}
