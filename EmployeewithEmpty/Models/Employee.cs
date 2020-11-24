using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeewithEmpty.Models
{
    public class Employee
    {
      public List<tbl_Employee> getEmployee()
        {

            string ConnString = "Data Source = LAPTOP-7VF007UN\\SQLEXPRESS; Initial Catalog = EmpPortal; " + "Integrated Security = True";
            string SqlString = "Select * from tblEmployee";
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                List<tbl_Employee> listobjemp = new List<tbl_Employee>();
                using (SqlCommand cmd = new SqlCommand(SqlString, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tbl_Employee objemp = new tbl_Employee();
                            
                            objemp.Id = (int)reader["Id"];
                            objemp.Name= (string)reader["Name"];
                            objemp.Location = (string)reader["Location"];
                            objemp.Manager = (string)reader["Manager"];
                            objemp.DeptName = (string)reader["DeptName"];

                            listobjemp.Add(objemp);
                        }
                    }

                    

                    return listobjemp;
                }
            }
        }
    }
}