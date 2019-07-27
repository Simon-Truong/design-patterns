using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class SubtractChain : Chain
    {
        public override void HandleRequest(Equation equation)
        {
            if (equation.GetOperation() == "subtract")
            {
                Console.WriteLine($"{equation.GetFirstOperand()} - {equation.GetSecondOperand()} = {equation.GetFirstOperand() - equation.GetSecondOperand()}");
            }
            else
            {
                _chain.HandleRequest(equation);
            }
        }
    }
}
