using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class VWCarPackage : ICarPackage
    {
        public string GetDiscription()
        {
            return "Congratulations, you have purchased the Volkswagen GOLF";
        }

        public int GetPrice()
        {
            return 30000;
        }
    }
}
