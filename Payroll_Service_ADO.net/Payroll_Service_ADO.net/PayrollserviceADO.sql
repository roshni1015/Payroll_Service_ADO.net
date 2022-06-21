use EmployeePayroll_ADO;
go
Alter procedure[dbo].[SpAddEmployeePayroll] 
(
   @Name varchar(25),
   @StartDate Date,
   @Gender varchar(25),
   @PhoneNumber varchar(20),
   @Address varchar(100),
   @Department varchar(25),
   @BasicPay Float,
   @Deductions Float,
   @TaxablePay Float,
   @IncomeTax Float,
   @NetPay Float

)
as 
begin
Insert into EmployeeDetails Values ( @Name, @StartDate ,@Gender, @PhoneNumber, @Address, @Department, @BasicPay,@Deductions, @TaxablePay, @IncomeTax,@NetPay)
End
Select * from EmployeeDetails;
