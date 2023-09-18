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
    public partial class CategoryManagement : Form
    {
        public CategoryManagement()
        {
            InitializeComponent();
        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            UpdateCategoryList();
        }

        private void CategoryManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void UpdateCategoryList()
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            categoryListDataGridView.DataSource = categoryDataAccess.GetAllCategories();

        }
        

        private void addCategoryButton_Click_1(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if (categoryDataAccess.AddNewCategory(addCategoryNameTextBox.Text))
            {
                MessageBox.Show("Category added");
                UpdateCategoryList();
            }
            else
            {
                MessageBox.Show("Error in adding");
            }

        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            if (categoryDataAccess.DeleteCategory(Convert.ToInt32(deleteCategoryIdTextBox.Text)))
            {
                MessageBox.Show("Category deleted");
                UpdateCategoryList();
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


