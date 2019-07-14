using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class TV : EletronicDevice
    {
        // known as refined abstraction
        public TV(IRemoteControl remoteControl) : base(remoteControl)
        {

        }
    }
}
