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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails.Show();
            this.Hide();
        }

        private void availableProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
            this.Hide();
        }

        private void managerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerDetails managerDetails = new ManagerDetails();
            managerDetails.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void supplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierDetails supplierDetails = new SupplierDetails();
            supplierDetails.Show();
            this.Hide();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            userList.Show();
            this.Hide();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.Show();
            this.Hide();
        }

        private void saleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleList saleList = new SaleList();
            saleList.Show();
            this.Hide();
        }
    }
    }


