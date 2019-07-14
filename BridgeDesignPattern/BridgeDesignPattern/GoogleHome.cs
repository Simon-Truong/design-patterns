using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class GoogleHome : EletronicDevice
    {
        public GoogleHome(IRemoteControl remoteControl) : base(remoteControl)
        {

        }
        // known as refined abstraction
    }
}
