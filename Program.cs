

using System;

namespace EmployeeWageCompute
{
    ///  UC - 5 Calculating Wages for a Month Assuming 20 Working
    /// </summary>
    class Program
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        static void Main(string[] args)
        {
            //local variable
            int empHrs = 0;
            int empWgae = 0;
            int totalEmpWage = 0;

            //pre defined random class
            Random random = new Random();

            //Repitation statement
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
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
                Console.WriteLine("Day" + day + "EmployeeWage is =" + empWgae);

                //totalEmpWage=totalEmpWage+empWage
                totalEmpWage += empWgae;
            }
            Console.WriteLine("Total Employee wage for {0} days is={1}", NUM_OF_WORKING_DAYS, totalEmpWage);
            Console.ReadLine();
        }
    }
}






