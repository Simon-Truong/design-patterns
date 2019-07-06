using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class Bird : Animal
    {
        public Bird()
        {
            _FlyType = new CanFly();
        }

        public override string Eat()
        {
            return "Bird is eating";
        }

        public override string Sleep()
        {
            return "Bird is sleeping";
        }

        public override string TryToFly()
        {
            return _FlyType.Fly();
        }
    }
}
