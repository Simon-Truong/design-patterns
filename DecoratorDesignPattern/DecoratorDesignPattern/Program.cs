using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VWCarPackage vwCarPackage = new VWCarPackage();

            Console.WriteLine(vwCarPackage.GetDiscription());
            Console.WriteLine(vwCarPackage.GetPrice());

            Console.WriteLine(new LeatherSeats(vwCarPackage).GetDiscription());
            Console.WriteLine(new LeatherSeats(vwCarPackage).GetPrice());

            Console.WriteLine(new SunRoof(new LeatherSeats(vwCarPackage)).GetDiscription());
            Console.WriteLine(new SunRoof(new LeatherSeats(vwCarPackage)).GetPrice());

            Console.WriteLine(new DualClimateControl(new SunRoof(new LeatherSeats(vwCarPackage))).GetDiscription());
            Console.WriteLine(new DualClimateControl(new SunRoof(new LeatherSeats(vwCarPackage))).GetPrice());
            Console.ReadKey();
        }
    }
}
