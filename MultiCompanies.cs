using System;
namespace EmployeeWageCompute
{
    internal class MultiCompanies
    {
        int totalComapniesWage = 0;
        int numberOfCompanies = 5;

        public int StartCompanyWages()
        {
            for (int i = 0; i < 5; i++)
            {
                Company company = new Company();
                totalComapniesWage += company.EmpWageCal();
            }
            return totalComapniesWage;
        }

    }
}
