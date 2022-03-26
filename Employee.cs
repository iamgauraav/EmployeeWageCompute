using System;
namespace EmployeeWageCompute
{
    public class EmployeeBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmployeeBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage (string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].settotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());

            }

        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            // local Variables 
            int empHrs = 0, totalEmpHr = 0, totalWorkingDays = 0;

            while (totalEmpHr <= companyEmpWage.maxHoursPerMonth  && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                //pre defined random values 
                Random random = new Random();
                //next method(),0-initial point,4-no. of elements 
                int empCheck = random.Next(0, 3);

                // Switch Selection statement
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

                totalEmpHr += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }
            return totalEmpHr + companyEmpWage.empRatePerHour; 
        }
    }
}
