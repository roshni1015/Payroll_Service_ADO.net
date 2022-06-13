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
    }
}