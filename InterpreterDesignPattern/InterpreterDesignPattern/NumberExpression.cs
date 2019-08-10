using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterDesignPattern
{
    public class NumberExpression : IExpression
    {
        public int _number;

        public NumberExpression(int number)
        {
            _number = number;
        }

        public int Interpret()
        {
            return _number;
        }
    }
}
