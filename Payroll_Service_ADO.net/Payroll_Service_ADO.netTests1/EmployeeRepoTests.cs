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
    public class EmployeeRepoTests
    {
        [TestMethod()]
        public void UpdateBasicPayTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeePayroll payroll = new EmployeePayroll();
            double expected = 3000000;
            employeeRepo.UpdateBasicPay();
            double salary = employeeRepo.UpdateBasicPay();
            Assert.AreEqual(expected, salary);
        }

        [TestMethod()]
        public void SumFunctionTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeePayroll payroll = new EmployeePayroll();
            double expected = 3270000;
            double SumOfTheSalary = employeeRepo.SumFunction();
            Assert.AreEqual(expected, SumOfTheSalary);
        }

        [TestMethod()]
        public void AverageFunctionTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeePayroll payroll = new EmployeePayroll();
            double expected = 3270000;
            double AverageSalary = employeeRepo.AverageFunction();
            Assert.AreEqual(expected, AverageSalary);
        }

        [TestMethod()]
        public void MinimumFunctionTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeePayroll payroll = new EmployeePayroll();
            double expected = 3270000;
            double minimum = employeeRepo.MinimumFunction();
            Assert.AreEqual(expected, minimum);
        }

        [TestMethod()]
        public void MaximumFunctionTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeePayroll payroll = new EmployeePayroll();
            double expected = 3270000;
            double maximum = employeeRepo.MaximumFunction();
            Assert.AreEqual(expected, maximum);
        }

        [TestMethod()]
        public void CountFunctionTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeePayroll payroll = new EmployeePayroll();
            int expected = 1;
            int count = employeeRepo.CountFunction();
            Assert.AreEqual(expected, count);
        }
    }
}