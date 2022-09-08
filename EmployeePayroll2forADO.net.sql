create table EmployeePayroll2
(
EmployeeID int primary key identity,
EmployeeName varchar(255),
PhoneNumber varchar(255),
Address varchar(255),
Department varchar(255),
Gender char(1),
BasicPay float,
Deductions float,
TaxablePay float,
Tax float,
NetPay float,
StartDate datetime,
City varchar(255),
Country varchar(255)
)

select * from EmployeePayroll2