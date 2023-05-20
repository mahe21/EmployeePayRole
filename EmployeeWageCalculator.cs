using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRole
{
    internal class EmployeeWageCalculator
    {
        static int WagePerHour = 20;
        static int FullDayHour = 8;
        static int partTimeHour = 4;
        static int workingDaysPerMonth = 20;
        static int noOfDaysPresent = 20;
        public int totalHours = 0;
        public int totalDaysPresent = 0;
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
    }
}
