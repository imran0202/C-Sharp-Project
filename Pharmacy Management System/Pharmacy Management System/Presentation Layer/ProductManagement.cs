using Pharmacy_Management_System.Data_Access_Layer;
using Pharmacy_Management_System.Presentation_Layer.Data_Access_Layer;
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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
            ProductDataAccess productDataAccess = new ProductDataAccess();
            productListDataGridView.DataSource = productDataAccess.GetAllProducts();
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            addCategoryComboBox.DataSource = categoryDataAccess.GetAllCategoryNames();
            
        }
        void UpdateProductList()
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            productListDataGridView.DataSource = productDataAccess.GetAllProducts();

        }

        private void ProductManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            UpdateProductList();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void searchProductTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            searchProductDataGridView.DataSource = productDataAccess.GetProductsByName(searchProductTextBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int catId = categoryDataAccess.GetCategoryIdByName(addCategoryComboBox.Text);
            if (catId > 0)
            {
                ProductDataAccess productDataAccess = new ProductDataAccess();
                if (productDataAccess.AddNewProduct(addProductNameTextBox.Text, Convert.ToDouble(addPriceTextBox.Text), catId))
                {
                    MessageBox.Show("Product added");
                    UpdateProductList();
                }
                else
                {
                    MessageBox.Show("Error in adding");
                }
            }
            else
            {
                MessageBox.Show("Category not found");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ProductDataAccess productDataAccess = new ProductDataAccess();
                if (productDataAccess.DeleteProduct(Convert.ToInt32(deleteProductIdTextBox.Text)))
                {
                    MessageBox.Show("Product deleted");
                    UpdateProductList();
                }
                else
                {
                    MessageBox.Show("Error in deleting");
                }
            }
        }
    }
}
