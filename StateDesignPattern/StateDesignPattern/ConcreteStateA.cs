using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern
{
    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handling request by ConcreteStateA");
            context.SetState(new ConcreteStateB());
        }
    }
}
