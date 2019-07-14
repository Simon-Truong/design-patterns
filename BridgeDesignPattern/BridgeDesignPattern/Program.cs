using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TVRemoteControl tvRemoteControl = new TVRemoteControl();
            TV tv = new TV(tvRemoteControl);

            tv.IncreaseVolume();
            tv.GetVolume();

            tv.IncreaseVolume();
            tv.DecreaseVolume();
            tv.GetVolume();

            tv.RemoteControl.PressNext();
            tv.RemoteControl.PressBack();

            Console.WriteLine("---");

            GoogleHomeRemoteControl googleHomeRemoteControl = new GoogleHomeRemoteControl();
            GoogleHome googleHome = new GoogleHome(googleHomeRemoteControl);
            googleHome.RemoteControl.PressNext();
            googleHome.RemoteControl.PressBack();

            Console.ReadKey();
        }
    }
}
