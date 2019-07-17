using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person developer = new Person("David", 25, "Developer");
            developer.GetDetails();

            Person developer2 = developer.Clone() as Person;

            Console.WriteLine("Changing clone name and age");

            developer2.Name = "Cory";
            developer2.Age = 42;

            developer2.GetDetails();

            Console.WriteLine("---");
            Console.WriteLine("Making new pet");

            Pet dog = new Pet("B", "dog");
            dog.GetDetails();

            Console.WriteLine("---");

            PersonDeep individualWithPet = new PersonDeep("Mike", 30, "Lawyer", dog);
            PersonDeep individualWithPet2 = individualWithPet.Clone() as PersonDeep;

            individualWithPet2.Pet.Name = "A";
            individualWithPet2.Pet.Type = "Bird";

            individualWithPet.Pet.GetDetails();
            individualWithPet2.Pet.GetDetails();
            Console.ReadKey();
        }
    }
}
