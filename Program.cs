using System;
namespace EmployeeWageCompute
{
    public class program
    {/// <summary>
     /// UC-2 Calculate Daily Employee Wages.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            //constants
            int IS_FULL_TIME = 1;
            int RATE_PER_HOUR = 20;

            //local Variables
            int empHrs = 0;
            int empWage = 0;

            //Pre defined random class
            Random random = new Random();

            //Next method(),0-initial value,2-number of elements
            int empCheck = random.Next(0, 2);

            //If-else Selection statement
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * RATE_PER_HOUR;
            Console.WriteLine("Emp wage: " + empWage);

        }
    }
}
