using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Bird bird = new Bird();

            IVisitor drink = new Drink();
            IVisitor eat = new Eat();
            IVisitor sleep = new Sleep();

            Console.WriteLine(dog.Accept(drink));
            Console.WriteLine(cat.Accept(drink));
            Console.WriteLine(bird.Accept(drink));

            Console.WriteLine(dog.Accept(eat));
            Console.WriteLine(cat.Accept(eat));
            Console.WriteLine(bird.Accept(eat));

            Console.WriteLine(dog.Accept(sleep));
            Console.WriteLine(cat.Accept(sleep));
            Console.WriteLine(bird.Accept(sleep));


            Console.ReadKey();
        }
    }
}
