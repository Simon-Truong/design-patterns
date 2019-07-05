using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Honda : Car
    {
        public override string StartCar()
        {
            return "Starting Honda car.";
        }

        public override string StartDriving()
        {
            return "Driving Honda car.";
        }

        public override string StartTurning()
        {
            return "Turning Honda car.";
        }
    }
}
