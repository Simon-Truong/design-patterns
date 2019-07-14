using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class TVRemoteControl : IRemoteControl
    {
        // concrete implementor
        public void PressBack()
        {
            Console.WriteLine("Next channel");
        }

        public void PressNext()
        {
            Console.WriteLine("Previous channel");
        }
    }
}
