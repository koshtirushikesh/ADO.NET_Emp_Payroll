using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EmployeePayRoll
{
    public class EmployeeRepo
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Payroll_service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public bool AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                using(this.connection)
                {

                    SqlCommand Command = new SqlCommand("SpAddEmployeeDetails", this.connection);
                    Command.CommandType = CommandType.StoredProcedure;

                    this.connection.Open();
                    var result = Command.ExecuteNonQuery();
                    this.connection.Close();
                    if(result!=0)
                    { return true; }
                    return false;
                }
            }catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }

            finally 
            { 
                this.connection.Close();
            }
        }
    }
}
