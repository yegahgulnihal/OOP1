using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AppManager
    {
        public void Apply(ICreditManager creditManager,ILoggerService loggerService)
        {
            creditManager.Calculate(); //bütün kredilerin çalışabilmesi için
            loggerService.Log();       //log işlemin yapıldığına dair mesaj gönderir

        }
        public void PreCreditInform(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
