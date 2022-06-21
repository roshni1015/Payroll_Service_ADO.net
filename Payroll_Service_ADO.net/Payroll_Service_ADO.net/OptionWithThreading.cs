using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Service_ADO.net
{
    public class OptionWithThreading
    {
        public List<EmployeePayroll2> Employeeinfo = new List<EmployeePayroll2>();
        public void addEmployeeToPayRoll(List<EmployeePayroll2> employeeinfo)
        {
            employeeinfo.ForEach(employee =>
            {
                Console.WriteLine("Employee being added:" + employee.FirstName);
                this.addEmployeePayRoll(employee);
                Console.WriteLine("Employee Added :" + employee.FirstName);
            });
        }


        public void addEmployeePayRoll(EmployeePayroll2 emp)
        {
            Employeeinfo.Add(emp);
        }
    }
}
