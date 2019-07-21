using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class RestaurantFacade
    {
        private IPizza _pizza;
        private IBread _bread;
        public RestaurantFacade(IPizza pizza, IBread bread)
        {
            _pizza = pizza;
            _bread = bread;
        }

        public void ProcessOrder()
        {
            _pizza.GetPizza();
            _bread.GetBread();
        }
    }
}
