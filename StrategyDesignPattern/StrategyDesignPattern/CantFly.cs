using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class CantFly : IFly
    {
        public string Fly()
        {
            return "I can't fly";
        }
    }
}
