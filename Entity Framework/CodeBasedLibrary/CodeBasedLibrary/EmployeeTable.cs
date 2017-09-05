using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeBasedLibrary
{
    public class EmployeeTable
    {
        [Key]
        public int Employee_ID { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Location { get; set; }
        public decimal Employee_Salary { get; set; }
    }
}
