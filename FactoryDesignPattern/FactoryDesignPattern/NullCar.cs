using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class NullCar : Car
    {
        public override string StartCar()
        {
            return "";
        }

        public override string StartDriving()
        {
            return "";
        }

        public override string StartTurning()
        {
            return "";
        }
    }
}
