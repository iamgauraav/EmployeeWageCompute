
using System;
namespace EmployeeWageCompute
{
    public class program
    {/// <summary>
     /// UC-3 Add part time Employee and wage.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //local Variables
            int empHrs = 0;
            int empWage = 0;

            //Pre defined random class
            Random random = new Random();

            //Next method(),0-initial value,3-no. of elements
            int empCheck = random.Next(0, 3);

            //If else if selection statement
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;

            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
        }
    }
}
