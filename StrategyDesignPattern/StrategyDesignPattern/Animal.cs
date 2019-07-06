using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public abstract class Animal
    {
        protected IFly _FlyType;
        public abstract string Eat();
        public abstract string Sleep();
        public abstract string TryToFly();
        public void SetFlyType(IFly FlyType)
        {
            _FlyType = FlyType;
        }
    }
}
