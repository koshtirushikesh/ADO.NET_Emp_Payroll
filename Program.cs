namespace EmployeePayRoll
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to Emplayee Payroll");

            EmployeeModel employeeModel = new EmployeeModel();
            EmployeeRepo employeeRepo = new EmployeeRepo();

            employeeModel.EmployeeName = "Bruce Wayne";
            employeeModel.PhoneNumber = "8898338339";
            employeeModel.Address = "12 Street";
            employeeModel.Department = "Hr";
            employeeModel.Gender = 'M';
            employeeModel.BasicPay = 22000.00;
            employeeModel.Deductions = 1500.00;
            employeeModel.TaxablePay = 200.00;
            employeeModel.Tax = 300.00;
            employeeModel.NetPay = 25000.00;
            employeeModel.City = "Banglore";
            employeeModel.Country = "India";

            employeeRepo.AddEmployee(employeeModel);
        }
    }
}
