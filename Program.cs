using System;
namespace EmployeeWageCompute
{/// <summary>
 /// UC-8 Compute Employee Wagefor multiple companies
 /// </summary>
    class EmployeeWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            // local Variables 
            int empHrs = 0, totalEmpHr = 0, totalWorkingDays = 0;

            while (totalEmpHr <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                //pre defined random values 
                Random random = new Random();
                //next method(),0-initial point,4-no. of elements 
                int empCheck = random.Next(0, 3);

                // Switch Selection statement
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is Present for Part time");
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        Console.WriteLine("Employe is Present for Full time");
                        empHrs = 8;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }
                totalEmpHr += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }
            int totalEmpWage = totalEmpHr * empRatePerHour;
            Console.WriteLine("Total Emp Wage For Company : " + company + "is: " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(String[] args)
        {
            ComputeEmpWage("DMart", 20, 2, 10);
            ComputeEmpWage("Reliance", 10, 4, 20);
            Console.ReadLine();
        }
    }
}
