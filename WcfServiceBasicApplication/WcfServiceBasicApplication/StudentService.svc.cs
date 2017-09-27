using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceBasicApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudent
    {
        private static List<Student> _student = new List<Student>()
        {
            new Student
            {
                ID=1,
                Name="Subramani"
            },
             new Student
            {
                ID=2,
                Name="Harshada"
            }
        };
        public List<Student> GetStudent()
        {
            return _student;
        }

        public Student GetStudentById(int value)
        {
            return _student.Where(s => s.ID == value).FirstOrDefault();
        }
    }
}
