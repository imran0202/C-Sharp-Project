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
    public partial class SaleList : Form
    {
        public SaleList()
        {
            InitializeComponent();
            SaleDataAccess userDataAccess = new SaleDataAccess();
            saleListDataGridView.DataSource = userDataAccess.GetAllSales();
        }

        private void SaleList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
