using System;
using System.Collections.Generic;
using System.Data;
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
                            employee.StartDate = dr.GetString(2);
                            employee.Gender = dr.GetChar(3);
                            employee.PhoneNumber = dr.GetString(4);
                            employee.Address = dr.GetString(5);
                            employee.Department = dr.GetString(6);
                            employee.BasicPay = dr.GetInt32(7);
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
        public bool AddEmployee(EmployeePayroll Payroll)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SpAddEmployeePayroll", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", Payroll.Name);
                    command.Parameters.AddWithValue("@StartDate", Payroll.StartDate);
                    command.Parameters.AddWithValue("@Gender", Payroll.Gender);
                    command.Parameters.AddWithValue("@PhoneNumber", Payroll.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", Payroll.Address);
                    command.Parameters.AddWithValue("@Department", Payroll.Department);
                    command.Parameters.AddWithValue("@BasicPay", Payroll.BasicPay);
                    command.Parameters.AddWithValue("@Deductions", Payroll.Deductions);
                    command.Parameters.AddWithValue("@TaxablePay", Payroll.TaxablePay);
                    command.Parameters.AddWithValue("@IncomeTax", Payroll.IncomeTax);
                    command.Parameters.AddWithValue("@NetPay", Payroll.NetPay);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }

        }
        public double UpdateBasicPay()
        {
            EmployeePayroll employee = new EmployeePayroll();
            connection.Open();
            SqlCommand command = new SqlCommand("Update EmployeeDetails set BasicPay=3000000 where Name='Terissa'", connection);
            double result = command.ExecuteNonQuery();
            if (result == 1)
            {
                string query = @"Select BasicPay from EmployeeDetails where Name='Terissa';";
                SqlCommand cmd = new SqlCommand(query, connection);
                object res = cmd.ExecuteScalar();
                connection.Close();
                employee.BasicPay = (double)res;
             
            }
            connection.Close();
            return (employee.BasicPay);
        }
    }
}


