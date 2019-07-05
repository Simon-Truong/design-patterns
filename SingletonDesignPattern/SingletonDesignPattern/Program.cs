using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.getSingleton;
            Console.WriteLine("-----------------");
            var singleton2 = Singleton.getSingleton;
            singleton.Count();
            singleton.Count();
            singleton2.Count();
            Console.ReadKey();
        }
    }
}
