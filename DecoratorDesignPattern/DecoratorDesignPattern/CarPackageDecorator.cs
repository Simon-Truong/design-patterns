using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public abstract class CarPackageDecorator : ICarPackage
    {
        protected ICarPackage _carPackage;

        public CarPackageDecorator(ICarPackage carPackage)
        {
            _carPackage = carPackage;
        }

        public virtual string GetDiscription()
        {
            return _carPackage.GetDiscription();
        }

        public virtual int GetPrice()
        {
            return _carPackage.GetPrice();
        }
    }
}
