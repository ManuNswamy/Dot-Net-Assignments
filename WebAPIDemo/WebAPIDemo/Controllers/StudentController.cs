using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class StudentController : ApiController
    {
        public static List<Student> student = new List<Student>()
        {
            new Student() { StudentName = "Harshada",StudentRollNumber=123},
            new Student() { StudentName = "Manu",StudentRollNumber = 321}
        };

        // GET api/values
        public IEnumerable<Student> Get()
        {
            return student;
        }

        // GET api/values/5
        public IEnumerable<Student> Get(int id)
        {
            var student_specific = student.Where(student => student.StudentRollNumber == id);
            return student_specific;
        }

        // POST api/Student
        public IEnumerable<Student> Post([FromBody]Student add_student_object)
        {
            student.Add(add_student_object);
            return student;
        }

        // PUT api/Student/5
        public IEnumerable<Student> Put(int id, [FromBody]string value)
        {
            Student student_specific = new Student();
            student_specific = student.First(student => student.StudentRollNumber == id);
            student_specific.StudentName = value;
            return student;
        }

        // DELETE api/Student/5
        public IEnumerable<Student> Delete(int id)
        {
            Student student_specific = new Student();
            student_specific=student.First(student => student.StudentRollNumber == id);
            student.Remove(student_specific);
            return student;

        }
    }
}
