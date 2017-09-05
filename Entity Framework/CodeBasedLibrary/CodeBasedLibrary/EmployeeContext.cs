using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeBasedLibrary
{
   public class EmployeeContext:DbContext
    {
        public DbSet<EmployeeTable> Employee_Records { get; set; }
    }
}
