using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRole
{
    internal class EmployeeWageCalculator
    {
        public int WagePerHour;
        public int FullDayHour;
        public int partTimeHour;
        public int workingDaysPerMonth;
        public int totalHours = 0;
        public int totalDaysPresent = 0;
        public int totalWage;
        public string company;
        public EmployeeWageCalculator(string company, int wagePerHour, int FullDayHour, int partTimeHour, int workingDaysPerMonth)
        {
            this.company = company;
            this.WagePerHour = wagePerHour;
            this.FullDayHour = FullDayHour;
            this.partTimeHour = partTimeHour;
            this.workingDaysPerMonth = workingDaysPerMonth;
        }
        public int GetEmployeeWage()
        {
            int totalWage = 0;
            Random random = new Random();
            for (int i = 0; i < workingDaysPerMonth && totalHours <= 100; i++)
            {
                int number = random.Next(0, 3);
                switch (number)
                {
                    // 0 for full time
                    case 0:
                        totalDaysPresent++;
                        totalHours += FullDayHour;
                        totalWage = totalWage + (FullDayHour * WagePerHour);
                        break;
                    // 1 for partime
                    case 1:
                        totalDaysPresent++;
                        totalHours += partTimeHour;
                        totalWage += (partTimeHour * WagePerHour);
                        break;
                    //2 for absent
                    case 2:
                        totalWage += 0;
                        break;
                    default:
                        break;
                }
            }
            return totalWage;
        }
        public void PrintWageDetails()
        {
            int totalWage = this.GetEmployeeWage();
            int totalPresentDays = this.totalDaysPresent;
            int totalHours = this.totalHours;
            Console.WriteLine("Number of Hours Employee worked for the company " + this.company + ": " + totalHours + " hrs");
            Console.WriteLine("Number of Days Employee is Present: " + totalPresentDays + " Days");
            Console.WriteLine("total wages for the month is: " + totalWage + "/-");
        }
    }
}
