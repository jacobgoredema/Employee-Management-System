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
    public partial class frmEmployeeDetails : Form
    {
        public frmEmployeeDetails()
        {
            InitializeComponent();
        }

        public int SaveRecord { get; private set; }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var addEmployee = new frmAddEmployee();
            addEmployee.IdentityUpdated += this.SaveRecord;
            addEmployee.ShowDialog();
        }

        private void btnGeneratePayroll_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

        }
    }
}
