using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class SunRoof : CarPackageDecorator
    {
        public SunRoof(ICarPackage carPackage) : base(carPackage)
        {
        }

        public override string GetDiscription()
        {
            return _carPackage.GetDiscription() + " with/and sun roof";
        }

        public override int GetPrice()
        {
            return _carPackage.GetPrice() + 2000;
        }
    }
}
