using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder carBuilder = new CarBuilder();

            carBuilder
                .SetDoor("Black door")
                .SetRoof("Black roof")
                .SetSeats("Black seats")
                .SetWheels("Black wheels");

            Car car = carBuilder.BuildCar();

            Console.WriteLine(car.GetDoor());
            Console.WriteLine(car.GetRoof());
            Console.WriteLine(car.GetSeats());
            Console.WriteLine(car.GetWheels());

            Console.ReadKey();
        }
    }
}
