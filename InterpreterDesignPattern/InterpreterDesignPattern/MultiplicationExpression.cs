using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterDesignPattern
{
    public class MultiplicationExpression : IExpression
    {
        private readonly IExpression _leftExpression;

        private readonly IExpression _rightExpression;

        public MultiplicationExpression(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return _leftExpression.Interpret() * _rightExpression.Interpret();
        }
    }
}
