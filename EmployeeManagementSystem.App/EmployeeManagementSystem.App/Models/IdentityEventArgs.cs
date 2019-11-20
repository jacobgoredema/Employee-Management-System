using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.App.Models
{
    public class IdentityEventArgs
    {
        public IdentityEventArgs()
        {

        }

        public string Id { get;}
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string JoiningDate { get; set; }
        public string WageRate { get; set; }
        public string HoursWorked { get; set; }
    }
}
