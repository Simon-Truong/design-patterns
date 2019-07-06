using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class Dog : Animal
    {
        public Dog()
        {
            _FlyType = new CantFly();
        }
        public override string Eat()
        {
            return "Dog is eating";
        }

        public override string Sleep()
        {
            return "Dog is sleeping";
        }

        public override string TryToFly()
        {
            return _FlyType.Fly();
        }
    }
}
