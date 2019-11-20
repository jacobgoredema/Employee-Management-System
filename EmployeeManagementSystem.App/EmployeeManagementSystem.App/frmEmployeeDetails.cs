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
    public partial class frmEmployeeDetails : Form
    {
        public frmEmployeeDetails()
        {
            InitializeComponent();
        }

        public void SaveRecord(object sender,IdentityEventArgs e)
        {
            try
            {
                var count = dgvEmployee.Rows.Count - 1;
                dgvEmployee.Rows.Add();
                dgvEmployee.Rows[count].Cells[0].Value = e.Id;
                dgvEmployee.Rows[count].Cells[1].Value = e.FullName;
                dgvEmployee.Rows[count].Cells[2].Value = e.Address;
                dgvEmployee.Rows[count].Cells[3].Value = e.Contact;
                dgvEmployee.Rows[count].Cells[4].Value = e.Email;
                dgvEmployee.Rows[count].Cells[5].Value = e.Designation;
                dgvEmployee.Rows[count].Cells[6].Value = e.Department;
                dgvEmployee.Rows[count].Cells[7].Value = e.JoiningDate;
                dgvEmployee.Rows[count].Cells[8].Value = e.WageRate;
                dgvEmployee.Rows[count].Cells[9].Value = e.HoursWorked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
