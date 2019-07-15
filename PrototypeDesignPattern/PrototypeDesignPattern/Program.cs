using System;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address(10, "Apple", "Fruit");
            ShallowDetails shallowDetails = new ShallowDetails(1, "David", 24, address);

            Console.WriteLine("Original shallowDetails");
            Console.WriteLine(shallowDetails.Id);
            Console.WriteLine(shallowDetails.Name);
            Console.WriteLine(shallowDetails.Age);
            Console.WriteLine(shallowDetails.Address.StreetNumber);
            Console.WriteLine(shallowDetails.Address.StreetName);
            Console.WriteLine(shallowDetails.Address.Suburb);

            ShallowDetails shallowDetailsClone = shallowDetails.Clone() as ShallowDetails;

            Console.WriteLine("\nCloned shallowDetails");
            Console.WriteLine(shallowDetailsClone.Id);
            Console.WriteLine(shallowDetailsClone.Name);
            Console.WriteLine(shallowDetailsClone.Age);
            Console.WriteLine(shallowDetailsClone.Address.StreetNumber);
            Console.WriteLine(shallowDetailsClone.Address.StreetName);
            Console.WriteLine(shallowDetailsClone.Address.Suburb);

            shallowDetailsClone.Address.StreetName = "Banana";

            Console.WriteLine("\nMade changes");

            Console.WriteLine("\nOriginal shallowDetails");
            Console.WriteLine(shallowDetails.Id);
            Console.WriteLine(shallowDetails.Name);
            Console.WriteLine(shallowDetails.Age);
            Console.WriteLine(shallowDetails.Address.StreetNumber);
            Console.WriteLine(shallowDetails.Address.StreetName);
            Console.WriteLine(shallowDetails.Address.Suburb);
            Console.ReadLine();

            Console.WriteLine("\nCloned shallowDetails");
            Console.WriteLine(shallowDetailsClone.Id);
            Console.WriteLine(shallowDetailsClone.Name);
            Console.WriteLine(shallowDetailsClone.Age);
            Console.WriteLine(shallowDetailsClone.Address.StreetNumber);
            Console.WriteLine(shallowDetailsClone.Address.StreetName);
            Console.WriteLine(shallowDetailsClone.Address.Suburb);
            Console.ReadLine();

        }
    }
}
