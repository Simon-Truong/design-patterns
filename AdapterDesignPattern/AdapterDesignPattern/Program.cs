using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        { 
            Cat cat = new Cat();
            CatRobot catRobot = new CatRobot();

            Console.WriteLine(cat.Eat());
            Console.WriteLine(cat.Talk());
            Console.WriteLine(cat.Walk());

            Console.WriteLine(catRobot.Recharge());
            Console.WriteLine(catRobot.SpeakBinary());
            Console.WriteLine(catRobot.Roll());

            Adapter catAdapter = new Adapter(catRobot);

            Console.WriteLine(catAdapter.Eat());
            Console.WriteLine(catAdapter.Talk());
            Console.WriteLine(catAdapter.Walk());
        }
    }
}
