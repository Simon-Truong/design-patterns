using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    public class Equation
    {
        private int _firstOperand;
        private int _secondOperand;
        private string _operation;

        public Equation(int firstOperand, int secondOperand, string operation)
        {
            _firstOperand = firstOperand;
            _secondOperand = secondOperand;
            _operation = operation;
        }

        public int GetFirstOperand()
        {
            return _firstOperand;
        }

        public int GetSecondOperand()
        {
            return _secondOperand;
        }

        public string GetOperation()
        {
            return _operation;
        }
    }
}
