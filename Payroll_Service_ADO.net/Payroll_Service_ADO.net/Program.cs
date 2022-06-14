// See https://aka.ms/new-console-template for more information
using Payroll_Service_ADO.net;

Console.WriteLine("Welcome to Employee Payroll Service");
EmployeePayroll payroll = new();
EmployeeRepo repo = new();
repo.GetAllEmployeePayroll();
repo.AddEmployee(payroll);
while (true)
{
    Console.WriteLine("Choose the option : \n1)Create and retrieve values from Database\n2)Add Employee Details\n3)Update salary\n4)Aggregate Operations\n5)Get Employee details Of Date Range");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            repo.GetAllEmployeePayroll();
            break;
        case 2:
            payroll.Name = "Terissa";
           // payroll.StartDate = "2022-03-12";
            payroll.Gender = 'F';
            payroll.PhoneNumber = "8877665544";
            payroll.Address = "Mumbai";
            payroll.Department = "Developer";
            payroll.BasicPay = 35000;
            payroll.Deductions = 1500;
            payroll.TaxablePay = 1000;
            payroll.IncomeTax = 1000;
            payroll.NetPay = 500;
            repo.AddEmployee(payroll);
            break;
        case 3:
            Console.WriteLine("Enter Name of the Employee : ");
            //string Name = Console.ReadLine);
            repo.UpdateBasicPay();
            double salary = repo.UpdateBasicPay();
            Console.Write("Updated Salary of Employee : ");
            Console.WriteLine(salary);
            repo.GetAllEmployeePayroll();
            break;
        case 4:
            int count = repo.CountFunction();
            Console.WriteLine("Count of Records :" + count);
            double AverageSalary = repo.AverageFunction();
            Console.WriteLine("Average salary is :" + AverageSalary);
            double SumOfTheSalary = repo.SumFunction();
            Console.WriteLine("Sum of salaries is :" + SumOfTheSalary);
            double minimum = repo.MinimumFunction();
            Console.WriteLine("Minimum of salaries is :" + minimum);
            double maximum = repo.MaximumFunction();
            Console.WriteLine("Maximum of salaries is :" + maximum);
            break;
        case 5:
            repo.GetEmployeesByDateRange();
            break;
        default:
            Console.WriteLine("Please choose the correct option");
            break;
    }
}
