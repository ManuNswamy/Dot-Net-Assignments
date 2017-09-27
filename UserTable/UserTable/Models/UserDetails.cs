using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserTable.Models
{
    public class UserDetails
    {
        [Display (Name="Student ID")]
        public int Student_ID { get; set; }
        [Display(Name = "Student Name")]
        public string Student_Name { get; set; }
        [Display(Name = "Student Password")]
        public string Student_Password { get; set; }
    }
}