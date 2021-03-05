using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "123456";
            customer1.FirstName = "Büşra";
            customer1.LastName = "Şahin";
            customer1.TcNo = "11111111111";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "654321";
            customer2.CompanyName = "B.Ş";
            customer2.TaxNo = "6363636";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
