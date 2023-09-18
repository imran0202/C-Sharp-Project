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
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
            SaleDataAccess saleDataAccess = new SaleDataAccess();
            cartListDataGridView.DataSource = saleDataAccess.GetAllSales();
        }
        private void SaleDetails_Load(object sender, EventArgs e)
        {
            UpdateSaleList();
        }

        private void Sales_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void UpdateSaleList()
        {
            SaleDataAccess saleDataAccess = new SaleDataAccess();
            cartListDataGridView.DataSource = saleDataAccess.GetAllSales();

        }

        private void addSaleButton_Click(object sender, EventArgs e)
        {
            SaleDataAccess saleDataAccess = new SaleDataAccess();
            if (saleDataAccess.AddNewSale(addDateTextBox.Text, addMedicineNameTextBox.Text, addPriceTextBox.Text))
            {
                MessageBox.Show("Sales added");
                UpdateSaleList();
            }
            else
            {
                MessageBox.Show("Error in adding");
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
