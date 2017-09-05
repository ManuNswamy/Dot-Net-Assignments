using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDatabase
{
    public class Student
    {
        public SqlHelper sqlHelper;
        public string sqlQuery;
      
        public Student()
        {
            sqlHelper = new SqlHelper();
        }

        public void GetData()
        {
            sqlQuery = @"select * from [Table]";
            var sqlReader = sqlHelper.ExecuteQuery(sqlQuery);
            while(sqlReader.Read())
            {
                
                Console.WriteLine("Student Name :{0}",sqlReader[1]);
            }
            sqlReader.Close();

            sqlQuery = @"SELECT COUNT (Id) FROM[Table]";
            string sqlScalar = sqlHelper.ExecuteScalar(sqlQuery);
            Console.WriteLine("Count : {0}", sqlScalar);
        }
        public void GetDataSet()
        {
            sqlQuery = @"select * from [Table]";
            DataTable dt = sqlHelper.GetDataSet(sqlQuery);
            foreach(DataRow dr in dt.Rows)
            {
                Console.WriteLine("Student Name : {0}", dr[1].ToString());
            }
            dt.WriteXml(@"D:\text.xml");

        }
        public void SaveData()
        {
            Console.WriteLine("Enter ID");
            string student_id = Console.ReadLine();
            sqlQuery=string.Format(@"insert into[table] values({0}, 'Harshu', 97, '9892828199')",student_id);
            bool output = sqlHelper.ExecuteNonQuery(sqlQuery);
            if (output)
                Console.WriteLine("Write Successful");
        }
        public void UpdateDataSet()
        {
            sqlQuery = @"select * from [Table]";
            Console.WriteLine("Enter ID");
            int student_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            sqlHelper.update(sqlQuery, student_id, name);
        }

       
    }
}
