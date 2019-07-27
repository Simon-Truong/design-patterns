using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern
{
    public class Rectangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing rectangle");
        }
    }
}
