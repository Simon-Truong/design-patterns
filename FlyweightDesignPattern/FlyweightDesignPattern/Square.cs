using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern
{
    public class Square : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing square");
        }
    }
}
