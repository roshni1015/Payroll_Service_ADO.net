using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Service_ADO.net
{
    public class EmployeePayroll
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public char Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }

    }
    public class EmployeePayroll2
    {
        public EmployeePayroll2(int EmployeeID, string FirstName, string LastName, string Gender, DateTime StartDate, string Company, string Departent, string Address, int BasicPay, int Deductions, int TaxablePay, int IncomeTax, int NetPay)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.StartDate = StartDate;
            this.Company = Company;
            this.Departent = Departent;
            this.Address = Address;
            this.BasicPay = BasicPay;
            this.Deductions = Deductions;
            this.TaxablePay = TaxablePay;
            this.IncomeTax = IncomeTax;
            this.NetPay = NetPay;
        }

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime StartDate { get; set; }
        public string Company { get; set; }
        public string Departent { get; set; }
        public string Address { get; set; }
        public int BasicPay { get; set; }
        public int Deductions { get; set; }
        public int TaxablePay { get; set; }
        public int IncomeTax { get; set; }
        public int NetPay { get; set; }

    }
}
