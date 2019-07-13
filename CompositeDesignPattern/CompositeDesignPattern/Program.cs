using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee developer1 = new Employee(1, "Bob");
            Employee developer2 = new Employee(2, "Kev");

            Employee accountant1 = new Employee(3, "Ros");
            Employee accountant2 = new Employee(4, "Rob");

            //developer1.PrintDetails();
            //developer2.PrintDetails();

            Manager developmentManager = new Manager(5, "Don");
            developmentManager.AddSubordinate(developer1);
            developmentManager.AddSubordinate(developer2);

            Manager accountantManager = new Manager(5, "Lee");
            accountantManager.AddSubordinate(accountant1);
            accountantManager.AddSubordinate(accountant2);

            //developmentManager.PrintDetails();

            Manager CEO = new Manager(7, "Dee");
            CEO.AddSubordinate(developmentManager);
            CEO.AddSubordinate(accountantManager);

            CEO.PrintDetails();

            Console.ReadKey();
        }
    }
}
