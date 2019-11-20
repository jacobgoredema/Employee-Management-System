using EmployeeManagementSystem.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.App
{
    public partial class frmAddEmployee : Form
    {
        // add delegate
        public delegate void IdentityHander(object sender, IdentityEventArgs e);
            
        // event of the delegate
        public event IdentityHander IdentityUpdated;

        public frmAddEmployee()
        {
            InitializeComponent();
            cboDepartment.Items.Add("Admin");
            cboDepartment.Items.Add("Finance");
            cboDepartment.Items.Add("Customer Service");
            cboDepartment.Items.Add("Marketing");
            cboDepartment.SelectedIndex = 0;
        }

        
    }
}
