using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();
            Bread bread = new Bread();

            RestaurantFacade restaurant = new RestaurantFacade(pizza, bread);

            restaurant.ProcessOrder();

            Console.ReadKey();
        }
    }
}
