using Pharmacy_Management_System.Presentation_Layer.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.Data_Access_Layer
{
    class SupplierDataAccess : DataAccess
    {
        public List<Supplier> GetAllSuppliers()
        {
            string sql = "SELECT * FROM Suppliers";
            SqlDataReader reader = this.GetData(sql);
            List<Supplier> suppliers = new List<Supplier>();
            while (reader.Read())
            {
                Supplier supplier = new Supplier();
                supplier.SupplierId = (int)reader["SupplierId"];
                supplier.SupplierName = reader["SupplierName"].ToString();
                supplier.CompanyName = reader["CompanyName"].ToString();
                supplier.Email = reader["Email"].ToString();
                suppliers.Add(supplier);
            }
            return suppliers;
        }
        public bool AddNewSupplier(string SupplierName, string CompanyName,string Email)
        {
            string sql = "INSERT INTO Suppliers (SupplierName,CompanyName,Email) VALUES('" + SupplierName + "','" + CompanyName + "','" + Email + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteSupplier(int supplierid)
        {
            string sql = "DELETE FROM Suppliers WHERE SupplierId=" + supplierid;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
       
    }
}
