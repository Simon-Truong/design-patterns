using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesignPattern
{
    public class NullObject : Animal
    {
        public override string Eat()
        {
            return "";
        }

        public override string Talk()
        {
            return "";
        }
    }
}
