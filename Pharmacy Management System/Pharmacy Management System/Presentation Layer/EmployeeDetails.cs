using Pharmacy_Management_System.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.Presentation_Layer
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            employeeListDataGridView.DataSource = employeeDataAccess.GetAllEmployees();
        }
        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            UpdateEmployeeList();
        }

        private void EmployeeDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void UpdateEmployeeList()
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            employeeListDataGridView.DataSource = employeeDataAccess.GetAllEmployees();

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            if (employeeDataAccess.AddNewEmployee(addEmployeeNameTextBox.Text,addEmployeeEmailTextBox.Text,addEmployeeGenderTextBox.Text))
            {
                MessageBox.Show("Employee added");
                UpdateEmployeeList();
            }
            else
            {
                MessageBox.Show("Error in adding");
            }
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeDataAccess employeeDataAccess = new EmployeeDataAccess();
            if (employeeDataAccess.DeleteEmployee(Convert.ToInt32(deleteEmployeeIdTextBox.Text)))
            {
                MessageBox.Show("Employee deleted");
                UpdateEmployeeList();
            }
            else
            {
                MessageBox.Show("Error in deleting");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
