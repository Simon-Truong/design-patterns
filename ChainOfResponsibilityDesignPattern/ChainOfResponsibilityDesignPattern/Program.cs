using System;

namespace ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation Equation = new Equation(10, 5, "divide");

            Chain AddChain = new AddChain();
            Chain SubtractChain= new SubtractChain();
            Chain MultiplyChain = new MultiplyChain();
            Chain DivideChain = new DivideChain();


            AddChain.SetNextChain(SubtractChain);
            SubtractChain.SetNextChain(MultiplyChain);
            MultiplyChain.SetNextChain(DivideChain);

            AddChain.HandleRequest(Equation);
            Console.ReadLine();
        }
    }
}
