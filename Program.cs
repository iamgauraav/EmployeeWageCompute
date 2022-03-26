using System;
namespace EmployeeWageCompute
{/// <summary>
 /// UC-9 Ability to save the Total Wage for Each Company
 /// </summary>
    class EmployeeWage
    {
        static void Main(String[] args)
        {
            EmployeeBuilderObject dMart = new EmployeeBuilderObject("Dmart", 20, 2, 10);
            EmployeeBuilderObject reliance = new EmployeeBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
            Console.ReadLine();
            
        }
    }
}
