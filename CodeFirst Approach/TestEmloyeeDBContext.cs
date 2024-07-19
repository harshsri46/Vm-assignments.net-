using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Approach
{
    public  class TestEmloyeeDBContext:DbContext
    {
        public TestEmloyeeDBContext() : base("name=EmployeeInfo")
        {

        }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Department>Departments{ get; set; }
    }
}
