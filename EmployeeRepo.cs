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

                    Command.Parameters.AddWithValue("@EmployeeName", employeeModel.EmployeeName);
                    Command.Parameters.AddWithValue("@PhoneNumber", employeeModel.PhoneNumber);
                    Command.Parameters.AddWithValue("@Address", employeeModel.Address);
                    Command.Parameters.AddWithValue("@Department", employeeModel.Department);
                    Command.Parameters.AddWithValue("@Gender", employeeModel.Gender);
                    Command.Parameters.AddWithValue("@BasicPay", employeeModel.BasicPay);
                    Command.Parameters.AddWithValue("@Deductions", employeeModel.Deductions);
                    Command.Parameters.AddWithValue("@TaxablePay", employeeModel.TaxablePay);
                    Command.Parameters.AddWithValue("@Tax", employeeModel.Tax);
                    Command.Parameters.AddWithValue("@NetPay", employeeModel.NetPay);
                    Command.Parameters.AddWithValue("@StartDate", DateTime.Now);
                    Command.Parameters.AddWithValue("@City", employeeModel.City);
                    Command.Parameters.AddWithValue("@Country", employeeModel.Country);

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
