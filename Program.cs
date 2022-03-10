using System;

namespace EmployeeWageCompute
{/// <summary>
 ///  UC-4 Solving using Switch Case Statement
 /// </summary>
    class Program
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int RATE_PER_HOUR = 20;

        static void Main(string[] args)
        {
            //local variable
            int empHrs = 0;
            int empWgae = 0;

            //pre defined random class
            Random random = new Random();

            //Next method() 0-initial value,3-number of elements
            int empCheck = random.Next(0, 3);

            //Switch Selection statement
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
            empWgae = empHrs * RATE_PER_HOUR;
            Console.WriteLine("Employee wage: " + empWgae);
            Console.ReadLine();
        }
    }
}