using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data
{
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(string id,string fullName, string address, string contact,string email,string designation,string wageRate, string department, string dateOfJoin, string workedHour)
        {
            EmployeeId = id;
            FullName = fullName;
            Address = address;
            Contact = contact;
            Email = email;
            Designation = designation;
            Department = department;
            JoiningDate = string.IsNullOrEmpty(dateOfJoin)?DateTime.Now.ToShortDateString():dateOfJoin;
            WageRate = wageRate;
            WorkedHours = workedHour;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string JoiningDate { get; set; }
        public string WageRate { get; set; }
        public string WorkedHours { get; set; }
    }
}
