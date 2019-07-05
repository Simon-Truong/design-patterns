using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class LeatherSeats : CarPackageDecorator
    {
        public LeatherSeats(ICarPackage carPackage) : base(carPackage)
        {

        }

        public override string GetDiscription()
        {
            return _carPackage.GetDiscription() + " with/and leather seats";
        }

        public override int GetPrice()
        {
            return _carPackage.GetPrice() + 1000;
        }
    }
}
