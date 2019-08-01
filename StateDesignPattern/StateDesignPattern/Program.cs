using System;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IState concreteStateA = new ConcreteStateA();
            Context context = new Context(concreteStateA);

            context.Request();
            context.Request();

            Console.ReadLine();
        }
    }
}
