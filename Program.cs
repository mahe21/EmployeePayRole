namespace EmployeePayRole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            EmployeeWageCalculator wageCalculator = new EmployeeWageCalculator();
            int totalWage = wageCalculator.GetEmployeeWage();
            int totalPresentDays = wageCalculator.totalDaysPresent;
            int totalHours = wageCalculator.totalHours;

            Console.WriteLine("Number of Hours Employee worked: " + totalHours + " hrs");
            Console.WriteLine("Number of Days Employee is Present: " + totalPresentDays + " Days");
            Console.WriteLine("total wages for the month is: " + totalWage + "/-");
            Console.ReadKey();
        }
}