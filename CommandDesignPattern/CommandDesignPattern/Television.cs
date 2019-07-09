using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class Television : IElectronicDevice
    {
        public string TurnOff()
        {
            return "Turning TV off";
        }

        public string TurnOn()
        {
            return "Turning TV on";
        }

        public string DecreaseVolume()
        {
            return "Decreasing Volume";
        }

        public string IncreaseVolume()
        {
            return "Increasing Volume";
        }
    }
}
