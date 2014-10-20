using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Test
    {
        public static void Main()
        {
            ICustomer ico = new IndividualCustomer("Ico Petrov");
            ICustomer firma = new CompanyCustomer("Elit");

            IAccount icoAcc = new MortgageAccount(ico,1000m,3.4m);
            IAccount firmaAcc = new MortgageAccount(firma,30000m,6.5m);
            IAccount icoAcc2 = new DepositAccount(ico,500m,2.2m);
            IAccount firmaAcc2 = new LoanAccount(firma, 2000m, 10.5m);
            IList<IAccount> accounts = new List<IAccount>()
            {
                icoAcc,
                icoAcc2,
                firmaAcc,
                firmaAcc2
            };
            foreach (var item in accounts)
            {
                Console.WriteLine("{5} {0,-15}: {1:N2}, {2:N2}, {3:N2}, {4:N2}",
                    item.GetType().Name,
                    item.CalculateInterest(2),
                    item.CalculateInterest(3),
                    item.CalculateInterest(10),
                    item.CalculateInterest(13),
                    item.Customer.GetType().Name);
            }
        }
    }
}
