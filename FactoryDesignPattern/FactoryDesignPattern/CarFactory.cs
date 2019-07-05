using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class CarFactory : Factory<Car>
    {
        public override Car Build(string car) {
            switch (car) {
                case "Honda":
                    return new Honda();
                case "Toyota":
                    return new Toyota();
                default:
                    return new NullCar();
            }
        }
    }
}
