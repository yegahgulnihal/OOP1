using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ihtiyac Credit calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
