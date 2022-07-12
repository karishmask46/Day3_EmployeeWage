using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_EmployeeWage
{
    internal class UC6_EmpWageMaxWorkingHrs
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public void CalucalteEmpWage()
        {
            int EmpWorkingHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (EmpWorkingHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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
                totalEmpHrs += EmpWorkingHrs;
                Console.WriteLine("Total Employee Wage = " + totalEmpHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total monthly Wage : " + totalEmpWage);
        }

    }
}

