using Pharmacy_Management_System.Presentation_Layer.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.Data_Access_Layer
{
    class ManagerDataAccess : DataAccess
    {
        public List<Manager> GetAllManager()
        {
            string sql = "SELECT * FROM Managers";
            SqlDataReader reader = this.GetData(sql);
            List<Manager> managers = new List<Manager>();
            while (reader.Read())
            {
                Manager manager = new Manager();
                manager.ManagerId = (int)reader["ManagerId"];
                manager.ManagerName = reader["ManagerName"].ToString();
                manager.ManagerEmail = reader["ManagerEmail"].ToString();
                manager.ManagerGender = reader["Gender"].ToString();
                managers.Add(manager);
            }
            return managers;
        }
        public bool AddNewManager(string managerName, string managerEmail, string managerGender)
        {
            string sql = "INSERT INTO Managers(ManagerName,ManagerEmail,Gender) VALUES('" + managerName + "','" + managerEmail + "','" + managerGender + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteManager(int managerid)
        {
            string sql = "DELETE FROM Managers WHERE ManagerId=" + managerid;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
