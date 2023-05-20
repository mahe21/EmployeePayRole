namespace EmployeePayRole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            EmployeeWageCalculator reliance = new EmployeeWageCalculator("Reliance", 20, 8, 4, 20);
            reliance.PrintWageDetails();
            EmployeeWageCalculator airtel = new EmployeeWageCalculator("Airtel", 30, 7, 5, 30);
            airtel.PrintWageDetails();
            Console.ReadKey();
        }
    }
}