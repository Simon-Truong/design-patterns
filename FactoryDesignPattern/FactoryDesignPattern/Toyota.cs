using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Toyota : Car
    {
        public override string StartCar()
        {
            return "Starting Toyota car.";
        }

        public override string StartDriving()
        {
            return "Driving Toyota car.";
        }

        public override string StartTurning()
        {
            return "Steering Toyota car.";
        }
    }
}
