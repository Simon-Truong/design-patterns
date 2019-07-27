using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern
{
    public class NullObject : IShape
    {
        public void Print()
        {
            Console.WriteLine("");
        }
    }
}
