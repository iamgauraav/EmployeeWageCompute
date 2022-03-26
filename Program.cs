using System;
namespace EmployeeWageCompute
{/// <summary>
 /// UC-10 Ability to manage Employee Wage of multiple companies 
    /// </summary>
    class EmployeeWage
    {
        static void Main(String[] args)
        {
            EmployeeBuilderArray empWageBuilder = new EmployeeBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.ReadLine();
            
        }
    }
}
