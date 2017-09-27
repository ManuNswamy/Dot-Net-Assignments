using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService22_09
{
    [MessageContract]
    public class EmployeeRequest
    {
        [MessageHeader]
        public string key;
        [MessageBodyMember]
        public int EmpId;

    }

    [MessageContract]
    public class EmployeeResponse
    {
        [MessageHeader]
        public string CompanyName;
        [MessageBodyMember]
        public Employee Emp;
        [MessageBodyMember]
        public Department Dept;
        [MessageBodyMember]
        public Admin Admin;
        [MessageBodyMember]
        public Manager Manager;
    }

    [DataContract]
    public class Department
    {
        private int _DepartmentID;
        private string _DepartmentName;

        [DataMember]
        public int DepartmentID
        {
            get { return _DepartmentID; }
            set { _DepartmentID = value; }
        }
        [DataMember]
        public string DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }
    }




    [DataContract]
    public class Employee
    {
        private int _ID;
        private string _Name;
        private int _Age;
        private int _Salary;
        
        [DataMember]
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        [DataMember]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        [DataMember]
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        [DataMember]
        public int Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
    }

    [DataContract]
    public class Admin:Employee
    {
        private string _Admin_Username;
        [DataMember]
        public string Admin_Username
        {
            get { return _Admin_Username; }
            set { _Admin_Username = value; }
        }

    }

    [DataContract]
    public class Manager : Employee
    {
        private string _Manager_Username;
        [DataMember]
        public string Manager_Username
        {
            get { return _Manager_Username; }
            set { _Manager_Username = value; }
        }

    }
}