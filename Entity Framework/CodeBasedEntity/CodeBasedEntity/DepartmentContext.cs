using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeBasedEntity
{
    public class DepartmentContext: DbContext
    {
        public DbSet<Department> Department_Records { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().Property(u => u.Department_Name).HasColumnName("DeptName");
        }
    }
}

