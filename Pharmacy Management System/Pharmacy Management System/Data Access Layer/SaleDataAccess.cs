using Pharmacy_Management_System.Presentation_Layer.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.Data_Access_Layer
{
    class SaleDataAccess : DataAccess
    {
        public List<Sale> GetAllSales()
        {
            string sql = "SELECT * FROM Sales_1";
            SqlDataReader reader = this.GetData(sql);
            List<Sale> sales = new List<Sale>();
            while (reader.Read())
            {
                Sale sale = new Sale();
                sale.SalesNo = (int)reader["SalesNo"];
                sale.Date = reader["Date"].ToString();
                sale.MedicineName = reader["MedicineName"].ToString();
                sale.Price = Convert.ToDouble(reader["Price"]);
                sales.Add(sale);
            }
            return sales;
        }
        public bool AddNewSale(string Date, string medicineName, string Price)
        {
            string sql = "INSERT INTO Sales_1(Date,MedicineName,Price) VALUES('" + Date + "','" + medicineName + "','" + Price + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
