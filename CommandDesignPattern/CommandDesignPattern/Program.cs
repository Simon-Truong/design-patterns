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
            TurnTvOn turnTvOnCommand = new TurnTvOn(television);
            TvRemote turnOnTv = new TvRemote(turnTvOnCommand);

            Console.WriteLine(turnOnTv.ExecuteCommand());
            Console.ReadKey();
        }
    }
}
