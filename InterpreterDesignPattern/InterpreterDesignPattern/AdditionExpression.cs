using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterDesignPattern
{
    class AdditionExpression : IExpression
    {
        private readonly IExpression _leftExpression;

        private readonly IExpression _rightExpression;

        public AdditionExpression(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return _leftExpression.Interpret() + _rightExpression.Interpret();
        }
    }
}
