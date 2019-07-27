using System;

namespace FlyweightDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFatory shapeFactory = new ShapeFatory();

            IShape square = shapeFactory.GetShape("square");
            square.Print();
            Console.WriteLine(shapeFactory.GetCount());

            IShape rectangle = shapeFactory.GetShape("rectangle");
            rectangle.Print();
            Console.WriteLine(shapeFactory.GetCount());

            IShape square2 = shapeFactory.GetShape("square");
            square2.Print();
            Console.WriteLine(shapeFactory.GetCount());

            Console.ReadLine();
        }
    }
}
