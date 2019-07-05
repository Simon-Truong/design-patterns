using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesignPattern
{
    class Cat : Animal
    {
        public override string Eat()
        {
            return "Cat is eating.";
        }

        public override string Talk()
        {
            return "Cat is meowing.";
        }
    }
}
