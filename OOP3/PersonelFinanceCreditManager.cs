using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonelFinanceCreditManager : ICreditManager
    {
        public void Calculation()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
