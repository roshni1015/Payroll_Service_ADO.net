// See https://aka.ms/new-console-template for more information
using Payroll_Service_ADO.net;

Console.WriteLine("Welcome to Employee Payroll Service");
EmployeePayroll payroll = new();
EmployeeRepo repo = new();
repo.GetAllEmployeePayroll();