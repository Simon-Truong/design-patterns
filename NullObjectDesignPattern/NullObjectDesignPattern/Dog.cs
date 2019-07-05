using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesignPattern
{
    public class Dog : Animal
    {
        public override string Eat()
        {
            return "Dog is eating.";
        }

        public override string Talk()
        {
            return "Dog is barking.";
        }
    }
}
