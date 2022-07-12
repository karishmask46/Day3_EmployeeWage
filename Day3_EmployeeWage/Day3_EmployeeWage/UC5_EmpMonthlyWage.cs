using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_EmployeeWage
{
    internal class UC5_EmpMonthlyWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public void CalucalteEmpWage()
        {
            int EmpWorkingHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        EmpWorkingHrs = 8;
                        break;
                    case IS_PART_TIME:
                        EmpWorkingHrs = 4;
                        break;
                    default:
                        EmpWorkingHrs = 0;
                        break;
                }
                empWage = EmpWorkingHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Total Employee Wage = " + empWage);
            }
            Console.WriteLine("Total monthly Wage : " +totalEmpWage);
        }

    }
}
