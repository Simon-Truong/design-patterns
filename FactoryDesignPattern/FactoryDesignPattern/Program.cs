using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();

            Car honda = carFactory.Build("Honda");
            Car toyota = carFactory.Build("Toyota");
            Car car = carFactory.Build("");

            Console.WriteLine(honda.StartCar());
            Console.WriteLine(honda.StartDriving());
            Console.WriteLine(honda.StartTurning());

            Console.WriteLine(toyota.StartCar());
            Console.WriteLine(toyota.StartDriving());
            Console.WriteLine(toyota.StartCar());

            Console.WriteLine(car.StartDriving());
            Console.WriteLine(car.StartTurning());
            Console.ReadKey();
        }
    }
}
