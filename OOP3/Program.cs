using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personelFinanceCreditManager = new PersonelFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            ConsultManager consultManager = new ConsultManager();
            consultManager.ToApply(personelFinanceCreditManager, new List<ILoggerService> {new DatabaseLoggerService(), new FileLoggerService() } );

            List<ICreditManager> credits = new List<ICreditManager>() {personelFinanceCreditManager, transportCreditManager };

           // consultManager.CreditPrenotification(credits);


        }
    }
}
