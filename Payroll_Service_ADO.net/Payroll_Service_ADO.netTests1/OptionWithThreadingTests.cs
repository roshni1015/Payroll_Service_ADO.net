using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll_Service_ADO.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Service_ADO.net.Tests
{
    [TestClass()]
    public class OptionWithThreadingTests
    {
        [TestMethod()]
        public void AddingEmployeeTest()
        {
            List<EmployeePayroll2> employeeDetails2 = new List<EmployeePayroll2>();
            employeeDetails2.Add(new EmployeePayroll2(EmployeeID: 2, FirstName: "Roshni", LastName: "Adatrao", Gender: "Female", StartDate: DateTime.Now, Company: "TCS", Departent: "Testing", Address: "Pune", BasicPay: 40000, Deductions: 1000, TaxablePay: 10000, IncomeTax: 500, NetPay: 15000));
            employeeDetails2.Add(new EmployeePayroll2(EmployeeID: 1, FirstName: "Mahesh", LastName: "Kulkarni", Gender: "Male", StartDate: DateTime.Now, Company: "TCS", Departent: "Testing", Address: "Mumbai", BasicPay: 40000, Deductions: 1000, TaxablePay: 1000, IncomeTax: 500, NetPay: 15000));
            employeeDetails2.Add(new EmployeePayroll2(EmployeeID: 3, FirstName: "Vivek", LastName: "Patil", Gender: "Male", StartDate: DateTime.Now, Company: "TCS", Departent: "Testing", Address: "Nashik", BasicPay: 40000, Deductions: 1000, TaxablePay: 1000, IncomeTax: 500, NetPay: 15000));
            employeeDetails2.Add(new EmployeePayroll2(EmployeeID: 4, FirstName: "Pradnya", LastName: "Chavan", Gender: "Female", StartDate: DateTime.Now, Company: "TCS", Departent: "Testing", Address: "Mumbai", BasicPay: 40000, Deductions: 1000, TaxablePay: 1000, IncomeTax: 500, NetPay: 15000));
            employeeDetails2.Add(new EmployeePayroll2(EmployeeID: 5, FirstName: "Lavanya", LastName: "Kapoor", Gender: "Female", StartDate: DateTime.Now, Company: "TCS", Departent: "Testing", Address: "Banglore", BasicPay: 40000, Deductions: 1000, TaxablePay: 1000, IncomeTax: 500, NetPay: 15000));

            OptionWithThreading operationWIthThreads = new OptionWithThreading();
            DateTime StartdateTime = DateTime.Now;
            operationWIthThreads.AddingEmployee(employeeDetails2);
            DateTime StopDataTime = DateTime.Now;
            Console.WriteLine("Duration without Thread: " + (StopDataTime - StartdateTime));
        }

        [TestMethod()]
        public void AddingWithThreadTest()
        {
            List<EmployeePayroll2> employeeDetails2 = new List<EmployeePayroll2>();
            employeeDetails2.Add(new EmployeePayroll2(EmployeeID: 2, FirstName: "Roshni", LastName: "Adatrao", Gender: "Female", StartDate: DateTime.Now, Company: "TCS", Departent: "Testing", Address: "Pune", BasicPay: 40000, Deductions: 1000, TaxablePay: 10000, IncomeTax: 500, NetPay: 15000));
            employeeDetails2.Add(new EmployeePayroll2(EmployeeID: 1, FirstName: "Mahesh", LastName: "Kulkarni", Gender: "Male", StartDate: DateTime.Now, Company: "TCS", Departent: "Testing", Address: "Mumbai", BasicPay: 40000, Deductions: 1000, TaxablePay: 1000, IncomeTax: 500, NetPay: 15000));
            employeeDetails2.Add(new EmployeePayroll2(EmployeeID: 3, FirstName: "Vivek", LastName: "Patil", Gender: "Male", StartDate: DateTime.Now, Company: "TCS", Departent: "Testing", Address: "Nashik", BasicPay: 40000, Deductions: 1000, TaxablePay: 1000, IncomeTax: 500, NetPay: 15000));
            employeeDetails2.Add(new EmployeePayroll2(EmployeeID: 4, FirstName: "Pradnya", LastName: "Chavan", Gender: "Female", StartDate: DateTime.Now, Company: "TCS", Departent: "Testing", Address: "Mumbai", BasicPay: 40000, Deductions: 1000, TaxablePay: 1000, IncomeTax: 500, NetPay: 15000));
            employeeDetails2.Add(new EmployeePayroll2(EmployeeID: 5, FirstName: "Lavanya", LastName: "Kapoor", Gender: "Female", StartDate: DateTime.Now, Company: "TCS", Departent: "Testing", Address: "Banglore", BasicPay: 40000, Deductions: 1000, TaxablePay: 1000, IncomeTax: 500, NetPay: 15000));


            OptionWithThreading operationWIthThreads = new OptionWithThreading();
            DateTime StartdateTime = DateTime.Now;
            operationWIthThreads.AddingEmployee(employeeDetails2);
            DateTime StopDataTime = DateTime.Now;
            Console.WriteLine("Duration without Thread: " + (StopDataTime - StartdateTime));
        
            DateTime StartdateTimeThread = DateTime.Now;
            operationWIthThreads.AddingWithThread(employeeDetails2);
            DateTime StopDataTimeThread = DateTime.Now;
            Console.WriteLine("Duration with Thread: " + (StopDataTimeThread - StartdateTimeThread));

        }
    }
}