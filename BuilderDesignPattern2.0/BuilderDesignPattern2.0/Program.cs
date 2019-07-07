using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            GreenHouseBuilder greenHouseBuilder = new GreenHouseBuilder();
            WoodHouseBuilder woodHouseBuilder = new WoodHouseBuilder();

            Engineer engineer = new Engineer(woodHouseBuilder);
            engineer.ConstructHouse();
            House woodHouse = engineer.GetHouse();

            Console.WriteLine(woodHouse.GetRoof());
            Console.WriteLine(woodHouse.GetWalls());
            Console.WriteLine(woodHouse.GetDoor());
            Console.WriteLine(woodHouse.GetWindow());

            engineer = new Engineer(greenHouseBuilder);
            engineer.ConstructHouse();
            House greenHouse = engineer.GetHouse();

            Console.WriteLine(greenHouse.GetRoof());
            Console.WriteLine(greenHouse.GetWalls());
            Console.WriteLine(greenHouse.GetDoor());
            Console.WriteLine(greenHouse.GetWindow());

            Console.ReadKey();
        }
    }
}
