using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public abstract class EletronicDevice
    {
        // known as abstraction
        private int Volume;
        public IRemoteControl RemoteControl;
        public EletronicDevice(IRemoteControl remoteControl)
        {
            Volume = 0;
            RemoteControl = remoteControl;
        }
        public void IncreaseVolume()
        {
            Volume++;
            Console.WriteLine($"Volume has been increased");
        }
        public void DecreaseVolume()
        {
            Volume--;
            Console.WriteLine($"Volume has been decreased");
        }
        public void GetVolume()
        {
            Console.WriteLine($"Current Volume: {Volume}");
        }
    }
}
