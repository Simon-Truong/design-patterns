using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesignPattern
{
    class Bird : Animal
    {
        public override string Eat()
        {
            return "Bird is eating";
        }

        public override string Talk()
        {
            return "Bird is chirping";
        }
    }
}
