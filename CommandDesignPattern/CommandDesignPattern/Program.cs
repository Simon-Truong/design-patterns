using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Television television = new Television();
            TurnTvOn turnOnTvCommand = new TurnTvOn(television);
            TurnTvOff turnOffCommand = new TurnTvOff(television);
            IncreaseTvVolume increaseTvVolumeCommand = new IncreaseTvVolume(television);
            DecreaseTvVolume decreaseTvVolumeCommand = new DecreaseTvVolume(television);

            TvRemote turnOnTv = new TvRemote(turnOnTvCommand);
            TvRemote turnOffTv = new TvRemote(turnOffCommand);
            TvRemote increaseTvVolume = new TvRemote(increaseTvVolumeCommand);
            TvRemote decreaseTvVolume = new TvRemote(decreaseTvVolumeCommand);

            Console.WriteLine(turnOnTv.ExecuteCommand());
            Console.WriteLine(turnOffTv.ExecuteCommand());
            Console.WriteLine(increaseTvVolume.ExecuteCommand());
            Console.WriteLine(decreaseTvVolume.ExecuteCommand());
            Console.ReadKey();
        }
    }
}
