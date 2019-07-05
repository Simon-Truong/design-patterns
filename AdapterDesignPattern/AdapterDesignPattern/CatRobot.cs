using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class CatRobot : IRobot
    {
        public string Recharge()
        {
            return "Cat robot is recharging.";
        }

        public string Roll()
        {
            return "Cat robot is rolling.";
        }

        public string SpeakBinary()
        {
            return "Cat robot is speaking in binary.";
        }
    }
}
