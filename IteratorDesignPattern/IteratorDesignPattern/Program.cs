using System;

namespace IteratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate aggregate = new Aggregate();
            aggregate[0] = "Item 1";
            aggregate[1] = "Item 2";
            aggregate[2] = "Item 3";
            aggregate[3] = "Item 4";

            Console.WriteLine(aggregate.Count);

            Iterator iterator = aggregate.CreateIterator();

            Console.WriteLine(iterator.First());
            Console.WriteLine(iterator.CurrentItem());

            object item = iterator.First();

            while (item != null)
            {
                Console.WriteLine(item);
                item = iterator.Next();
            }

            Console.WriteLine(iterator.First());
            Console.WriteLine(iterator.CurrentItem());

            Console.ReadLine();
        }
    }
}
