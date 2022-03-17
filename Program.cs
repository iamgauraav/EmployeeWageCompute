
using System;
namespace EmployeeWageCompute
{/// <summary>
/// /UC7 Refactor the code to write method for Employee Wage Calculation for a month
/// </summary>
    public class program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOURS = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        //Creating method for checking employee attendance
        public static int empAttendance()
        {
            Random random = new Random();
            int empAttendance = random.Next(0, 3);
            return empAttendance;
        }

        //creating method to calculate employee wage
        public static void empWage()
        {

            //local Variablce
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays <= NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;

                //Predefined class for generating random vales
                Random random = new Random();

                //Next method(),0-initial point,3-no. of elements
                int empCheck = random.Next(0, 3);

                //Switch Selection statement execution steps are less
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOURS;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            
        }
        static void Main(String[] args)
        {
            program.empWage();
            Console.ReadLine();

        }
    }
}



