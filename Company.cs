using System;
namespace EmployeeWageCompute
{
    public class Company
    {
        int totalWageEmployee = 0;
        int numOfEmployees = 30;

        public int EmpWageCal()
        {
            for (int i = 0; i < numOfEmployees; i++)
            {
                EmployeeWage emp = new EmployeeWage();
                totalWageEmployee += emp.StartWageCal();
            }
            return totalWageEmployee;
        }
    }
}
