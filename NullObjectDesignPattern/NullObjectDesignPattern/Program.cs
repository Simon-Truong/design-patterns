using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = null;

            Console.WriteLine("Pick an Animal: \"bird\", \"cat\", \"dog\"");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "bird":
                    animal = new Bird();
                    break;
                case "cat":
                    animal = new Cat();
                    break;
                case "dog":
                    animal = new Dog();
                    break;
                default:
                    animal = new NullObject();
                    break;
            }

            Console.WriteLine(animal.Eat());
            Console.WriteLine(animal.Talk());

            Console.ReadKey();
        }
    }
}
