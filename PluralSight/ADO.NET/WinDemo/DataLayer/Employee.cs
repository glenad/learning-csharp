using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public void Load(SqlDataReader reader)
        {
            EmployeeId = Int32.Parse(reader["BusinessEntityId"].ToString());
        }
    }
}
