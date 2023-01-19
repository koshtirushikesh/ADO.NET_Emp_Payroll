namespace EmployeePayRoll
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to Emplayee Payroll");

            EmployeeModel employeeModel = new EmployeeModel();
            EmployeeRepo employeeRepo = new EmployeeRepo();
            employeeRepo.AddEmployee(employeeModel);
        }
    }
}
