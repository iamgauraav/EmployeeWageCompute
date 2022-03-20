using System;
namespace EmployeeWageCompute
{
    public class EmployeeWage
    {
        public int  StartWageCal()
        {
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAYS = 20;


            // local Variables 
            int empHrs = 0;
            int empWage = 0;
            int totalEmpwage = 0;

            //pre defined random values 
            Random random = new Random();
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                //next method(),0-initial point,4-no. of elements 
                int empCheck = random.Next(0, 4);

                //Switch Selection statement 
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Day " + day + " EmployeeWage is =" + empWage);
                //totalEmpWage=totalEmpWage+empWage 
                totalEmpwage += empWage;
            }
            Console.WriteLine("Total Employee wage for {0} days is={1}", NUM_OF_WORKING_DAYS, totalEmpwage);
            return empWage;
        }
    }
}
