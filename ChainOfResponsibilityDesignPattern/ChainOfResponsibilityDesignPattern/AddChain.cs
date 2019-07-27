using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class AddChain : Chain
    {
        public override void HandleRequest(Equation equation)
        {
            if (equation.GetOperation() == "add")
            {
                Console.WriteLine($"{equation.GetFirstOperand()} + {equation.GetSecondOperand()} = {equation.GetFirstOperand() + equation.GetSecondOperand()}");
            }
            else
            {
                _chain.HandleRequest(equation);
            }
        }
    }
}
