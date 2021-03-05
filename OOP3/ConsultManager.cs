using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ConsultManager
    {
        public void ToApply(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Calculation();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void CreditPrenotification(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculation();
            }
        }
    }
}
