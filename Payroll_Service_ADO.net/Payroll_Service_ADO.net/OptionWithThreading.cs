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
        public void AddingEmployee(List<EmployeePayroll2> employeeinfo)
        {
            employeeinfo.ForEach(employee =>
            {
                Console.WriteLine("Employee being added:" + employee.FirstName);
                this.AddingEmployee(employee);
                Console.WriteLine("Employee Added :" + employee.FirstName);
            });
        }


        public void AddingEmployee(EmployeePayroll2 emp)
        {
            Employeeinfo.Add(emp);
        }
        public void AddingWithThread(List<EmployeePayroll2> employeeDetails)
        {
            employeeDetails.ForEach((employee) =>
            {
                Task Thread = new Task(() =>
                {
                    DateTime StartdateTime = DateTime.Now;

                    Console.WriteLine("Employee being added:" + employee.FirstName);
                    this.AddingEmployee(employee);
                    Console.WriteLine("Employee Added :" + employee.FirstName);

                    DateTime StopDataTime = DateTime.Now;
                    Console.WriteLine("Duration without Thread: " + (StopDataTime - StartdateTime));

                });
            });
        }
    }
}
