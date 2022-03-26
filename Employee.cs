using System;
namespace EmployeeWageCompute
{
    public class EmployeeBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        private int totalEmpWage;

        public EmployeeBuilderObject (string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        
        public void computeEmpWage()
        {
            // local Variables 
            int empHrs = 0, totalEmpHr = 0, totalWorkingDays = 0;

            while (totalEmpHr <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
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
            totalEmpWage = totalEmpHr + this.empRatePerHour;
            Console.WriteLine("Total Emp Wage For Company : " + company + "is: " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for company : " + this.company + "is: " + this.totalEmpWage;
        }
    }
}
