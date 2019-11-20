using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data
{
    public class EmployeeManagementContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
