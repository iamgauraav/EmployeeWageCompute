
using System;
namespace EmployeeWageCompute
{
    public class program
    {
        static void Main(String[] args)
        {
            MultiCompanies mulComp = new MultiCompanies();
            Console.WriteLine(mulComp.StartCompanyWages());
            Console.ReadLine();
        }
    }
}



