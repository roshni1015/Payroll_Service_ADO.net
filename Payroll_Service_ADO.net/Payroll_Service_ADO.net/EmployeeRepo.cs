using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Service_ADO.net
{
    public class EmployeeRepo
    {
        public static string connectionString = (@"Data Source=LAPTOP-RLUTTHG1; Initial Catalog =EmployeePayroll_ADO; Integrated Security = True;");
        SqlConnection connection = new SqlConnection(connectionString);

        public void GetAllEmployeePayroll()
        {
            try
            {
                EmployeePayroll employee = new EmployeePayroll();

                using (this.connection)
                {
                    string query = @"SELECT EmployeeID, Name, StartDate, Gender, PhoneNumber, Address, Department, BasicPay, Deductions, TaxablePay, IncomeTax, NetPay FROM EmployeeDetails";

                    SqlCommand cmd = new SqlCommand(query, this.connection);

                    this.connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            employee.EmployeeID = dr.GetInt32(0);
                            employee.Name = dr.GetString(1);
                            employee.StartDate = dr.GetDateTime(2);
                            employee.Gender = dr.GetString(3);
                            employee.PhoneNumber = dr.GetString(4);
                            employee.Address = dr.GetString(5);
                            employee.Department = dr.GetString(6);
                            employee.BasicPay = dr.GetDouble(7);
                            employee.Deductions = dr.GetDouble(8);
                            employee.TaxablePay = dr.GetDouble(9);
                            employee.IncomeTax = dr.GetDouble(10);
                            employee.NetPay = dr.GetDouble(11);


                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                            employee.EmployeeID,
                            employee.Name,
                            employee.StartDate,
                            employee.Gender,
                            employee.PhoneNumber,
                            employee.Address,
                            employee.Department,
                            employee.BasicPay,
                            employee.Deductions,
                            employee.TaxablePay,
                            employee.IncomeTax,
                            employee.NetPay);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {

                        Console.WriteLine("Data not Found");

                    }                    
                    dr.Close();
                    this.connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
