using System;
namespace EmployeeWageCompute
{/// <summary>
/// UC-1 Employee is present or absent.
/// </summary>
    public class program
    {
        static void Main(string[] args)
        {
            //constants
            int IS_PRESENT = 1;

            //pre defined random class
            Random random = new Random();

            //Next method() 0-initial value,2-number of elements
            int empCheck = random.Next(0, 2);

            //If Selection statement
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}