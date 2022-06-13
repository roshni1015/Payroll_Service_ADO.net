// See https://aka.ms/new-console-template for more information
using Payroll_Service_ADO.net;

Console.WriteLine("Welcome to Employee Payroll Service");
EmployeePayroll payroll = new();
EmployeeRepo repo = new();
/*repo.GetAllEmployeePayroll();
payroll.Name = "Terissa";
payroll.StartDate = "2022-03-12";
payroll.Gender = 'F';
payroll.PhoneNumber = "8877665544";
payroll.Address = "Mumbai";
payroll.Department = "Developer";
payroll.BasicPay = 35000;
payroll.Deductions = 1500;
payroll.TaxablePay = 1000;
payroll.IncomeTax = 1000;
payroll.NetPay = 500;

repo.AddEmployee(payroll);*/

Console.WriteLine("Enter Name of the Employee : ");
string Name = Console.ReadLine();
repo.UpdateBasicPay();
double salary = repo.UpdateBasicPay();
Console.Write("Updated Salary of Employee : ");
Console.WriteLine(salary);
repo.GetAllEmployeePayroll();