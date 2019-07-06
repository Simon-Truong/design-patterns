using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class Chicken : Animal
    {
        public Chicken()
        {
            _FlyType = new AlmostFly();
        }

        public override string Eat()
        {
            return "Chicken is eating";
        }

        public override string Sleep()
        {
            return "Chicken is sleeping";
        }

        public override string TryToFly()
        {
            return _FlyType.Fly();
        }
    }
}
