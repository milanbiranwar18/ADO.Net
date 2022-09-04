// See https://aka.ms/new-console-template for more information
using EmployeePayroll;

Console.WriteLine("Hello, World!");

Console.WriteLine("Wellcome to the EmployeePayroll porblem in ADO.Net");
EmployeeRepo repo = new EmployeeRepo();

EmployeeModel employeeModel = new EmployeeModel();
employeeModel.EmployeeName = "Bruce Wayne";
employeeModel.PhoneNumber = "54894516846";
employeeModel.Address = "Banglore";
employeeModel.Department = "Hr";
employeeModel.Gender = 'M';
employeeModel.BasicPay = 323400.00;
employeeModel.Deductions = 2500.00;
employeeModel.TaxablePay = 200.00;
employeeModel.NetPay = 25000.00;
employeeModel.City = "Banglore";
employeeModel.Country = "India";
//employeeModel.StartDate = DateTime.Now;
repo.AddEmployee(employeeModel);
