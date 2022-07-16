namespace Day3_EmployeeWage
{
    class Program
    {
        public  static void Main(string[] args)
        {

            EmployeeWageComputation employeeComputation = new EmployeeWageComputation(2);
            employeeComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            employeeComputation.CalculateEmpWage("TATA");

            employeeComputation.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
            employeeComputation.CalculateEmpWage("MAHINDRA");

            //employeeComputation.displayArray(Name);
            Console.WriteLine("Enter the name of the company you want to see the total wage of: ");
            string Name = Console.ReadLine();
            employeeComputation.displayArray(Name);
        }
    }
}