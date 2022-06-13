Create database EmployeePayroll_ADO;
use EmployeePayroll_ADO

Create table EmployeeDetails(EmployeeID int identity(1,1) Primary Key,
                             Name varchar(25),
							 StartDate date,
							 Gender varchar(25),
							 PhoneNumber varchar(20),
							 Address varchar(100),
							 Department varchar(25),
							 BasicPay Float,
							 Deductions Float,
							 TaxablePay Float,
							 IncomeTax Float,
							 NetPay Float);

Select * from EmployeeDetails;

Insert into EmployeeDetails values ('Mahesh', '2022-03-15',' M', '9876543210', 'Mumbai', 'Sales', 50000, 2000, 1500, 1000, 500)
Insert into EmployeeDetails values ('Roshni', '2022-03-10',' F', '9961873467', 'Pune', 'Sales', 50000, 2000, 1500, 1000, 500)
Insert into EmployeeDetails values ('Vivek', '2022-03-18',' M', '9289476168', 'Banglore', 'Sales', 50000, 2000, 1500, 1000, 500)
Insert into EmployeeDetails values ('Pradnya', '2022-03-20',' F', '9572829782', 'Aurangabad', 'Sales', 50000, 2000, 1500, 1000, 500)

SELECT EmployeeID, Name, StartDate, Gender, PhoneNumber, Address, Department, BasicPay, Deductions, TaxablePay, IncomeTax, NetPay FROM EmployeeDetails;




