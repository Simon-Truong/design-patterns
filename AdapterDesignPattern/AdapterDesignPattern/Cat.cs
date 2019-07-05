using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class Cat : IAnimal
    {
        public string Eat()
        {
            return "Cat is eating.";
        }

        public string Talk()
        {
            return "Cat is meowing.";
        }

        public string Walk()
        {
            return "Cat is walking.";
        }
    }
}
