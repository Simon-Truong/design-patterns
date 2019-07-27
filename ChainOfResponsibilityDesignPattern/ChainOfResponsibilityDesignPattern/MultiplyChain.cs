using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class MultiplyChain : Chain
    {
        public override void HandleRequest(Equation equation)
        {
            if (equation.GetOperation() == "multiply")
            {
                Console.WriteLine($"{equation.GetFirstOperand()} x {equation.GetSecondOperand()} = {equation.GetFirstOperand() * equation.GetSecondOperand()}");
            }
            else
            {
                _chain.HandleRequest(equation);
            }
        }
    }
}
