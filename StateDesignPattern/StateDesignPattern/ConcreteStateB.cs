using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handling request by ConcreteStateB");
        }
    }
}
