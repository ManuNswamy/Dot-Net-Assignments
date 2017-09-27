using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceBasicApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStudent
    {
        [OperationContract]
        List<Student> GetStudent();

        
        Student GetStudentById(int value);
        
    }
    public class Student
    {
        [DataMember]
        public int ID { get; set; }
        public String Name { get; set; }
    }


   
}
