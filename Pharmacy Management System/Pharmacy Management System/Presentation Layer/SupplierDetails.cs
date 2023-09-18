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
    public partial class SupplierDetails : Form
    {
        public SupplierDetails()
        {
            InitializeComponent();
            SupplierDataAccess supplierDataAccess = new SupplierDataAccess();
            supplierListDataGridView.DataSource = supplierDataAccess.GetAllSuppliers();
        }

        private void SupplierDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SupplierDetails_Load(object sender, EventArgs e)
        {
            UpdateSupplierList();
        }
        void UpdateSupplierList()
        {
            SupplierDataAccess supplierDataAccess = new SupplierDataAccess();
            supplierListDataGridView.DataSource = supplierDataAccess.GetAllSuppliers();

        }
        private void addSupplierButton_Click(object sender, EventArgs e)
        {
            SupplierDataAccess supplierDataAccess = new SupplierDataAccess();
            if (supplierDataAccess.AddNewSupplier(addSupplierNameTextBox.Text, addCompanyNameTextBox.Text, addSupplierEmailTextBox.Text))
            {
                MessageBox.Show("Supplier added");
                UpdateSupplierList();
            }
            else
            {
                MessageBox.Show("Error in adding");
            }
        }

        private void deleteSupplierButton_Click(object sender, EventArgs e)
        {
            SupplierDataAccess supplierDataAccess = new SupplierDataAccess();
            if (supplierDataAccess.DeleteSupplier(Convert.ToInt32(deleteSupplierIdTextBox.Text)))
            {
                MessageBox.Show("Supplier deleted");
                UpdateSupplierList();
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
