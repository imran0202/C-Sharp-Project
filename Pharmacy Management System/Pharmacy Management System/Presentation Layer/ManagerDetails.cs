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
    public partial class ManagerDetails : Form
    {
        public ManagerDetails()
        {
            InitializeComponent();
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            managerListDataGridView.DataSource = managerDataAccess.GetAllManager();
        }

        private void ManagerDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void ManagerDetails_Load(object sender, EventArgs e)
        {
            UpdateManagerList();
        }
        void UpdateManagerList()
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            managerListDataGridView.DataSource = managerDataAccess.GetAllManager();

        }

        private void addManagerButton_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if (managerDataAccess.AddNewManager(addManagerNameTextBox.Text, addManagerEmailTextBox.Text, addManagerGenderTextBox.Text))
            {
                MessageBox.Show("Manager added");
                UpdateManagerList();
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

        private void deleteManagerButton_Click(object sender, EventArgs e)
        {
            ManagerDataAccess managerDataAccess = new ManagerDataAccess();
            if (managerDataAccess.DeleteManager(Convert.ToInt32(deleteManagerIdTextBox.Text)))
            {
                MessageBox.Show("Manager deleted");
                UpdateManagerList();
            }
            else
            {
                MessageBox.Show("Error in deleting");
            }
        }
    }
}
