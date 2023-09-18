using Pharmacy_Management_System.Presentation_Layer.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.Data_Access_Layer
{
    class EmployeeDataAccess : DataAccess
    {

        public List<Employee> GetAllEmployees()
        {
            string sql = "SELECT * FROM Employees_1";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = (int)reader["EmployeeId"];
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.EmployeeEmail = reader["EmployeeEmail"].ToString();
                employee.EmployeeGender = reader["EmployeeGender"].ToString();
                employees.Add(employee);
            }
            return employees;
        }
        public bool AddNewEmployee(string employeeName, string employeeEmail,string employeeGender)
        {
            string sql = "INSERT INTO Employees_1(EmployeeName,EmployeeEmail,EmployeeGender) VALUES('" + employeeName + "','"+employeeEmail+"','"+employeeGender+"')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteEmployee(int employeeid)
        {
            string sql = "DELETE FROM Employees_1 WHERE EmployeeId=" + employeeid;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
      
    }
}
