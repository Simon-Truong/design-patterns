using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class GoogleHomeRemoteControl : IRemoteControl
    {
        // concrete implementor
        public void PressBack()
        {
            Console.WriteLine("Next song");
        }

        public void PressNext()
        {
            Console.WriteLine("Previous song");
        }
    }
}
