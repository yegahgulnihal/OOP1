using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditManager tasitCreditManager = new TasitCreditManager();         
            ICreditManager konutCreditManager = new KonutCreditManager();

        
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            AppManager appManager = new AppManager();
            appManager.Apply(ihtiyacCreditManager,databaseLoggerService ); //new DatabaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() 
            { 
                ihtiyacCreditManager,
                konutCreditManager
            };
            //appManager.PreCreditInform(credits);

            

        }
    }
}
