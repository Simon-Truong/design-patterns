using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InterpreterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string postFixExpression = "4 3 2 - 1 + *";
            string[] tokens = postFixExpression.Split(" ").Where(token => token != " ").ToArray();
            Stack<IExpression> stack = new Stack<IExpression>();

            for(int i = 0; i < tokens.Length; i++)
            {
                string token = tokens[i];
                if (IsOperator(token))
                {
                    IExpression rightExpression = stack.Pop();
                    IExpression leftExpression = stack.Pop();
                    IExpression operation = GetInstanceOperator(token, leftExpression, rightExpression);
                    int result = operation.Interpret();
                    stack.Push(new NumberExpression(result));
                } else
                {
                    stack.Push(new NumberExpression(Int32.Parse(token)));
                }
            }

            Console.WriteLine(stack.Pop().Interpret());
        }

        public static bool IsOperator(string token)
        {
            if (token ==("+") || token ==("-") || token ==("/") || token ==("*"))
            {
                return true;
            }

            return false;
        }

        public static IExpression GetInstanceOperator(string token, IExpression leftExpression, IExpression rightExpression)
        {
            switch(token)
            {
                case "+":
                    return new AdditionExpression(leftExpression, rightExpression);
                case "-":
                    return new SubtractionExpression(leftExpression, rightExpression);
                case "*":
                    return new MultiplicationExpression(leftExpression, rightExpression);
                case "/":
                    return new DivisionExpression(leftExpression, rightExpression);
                default:
                    return null;
            }
        }
    }
}
