using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Bird bird = new Bird();
            Chicken chicken = new Chicken();

            Console.WriteLine(dog.TryToFly());
            Console.WriteLine(bird.TryToFly());
            Console.WriteLine(chicken.TryToFly());

            dog.SetFlyType(new CanFly());
            Console.WriteLine(dog.TryToFly());

            bird.SetFlyType(new AlmostFly());
            Console.WriteLine(bird.TryToFly());

            chicken.SetFlyType(new CantFly());
            Console.WriteLine(chicken.TryToFly());

            Console.ReadKey();
        }
    }
}
