using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//(localdb)\v11.0
namespace CodeBasedEntity
{
    public class Department
    {
        [Key]
        public int Department_ID { get; set; }
        public string Department_Name { get; set; }
        public string Department_Location { get; set; }
        public string AddUrl { get; set; }
    }
}
