using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodOrder foodOrder = new FoodOrder();
            GiftOrder giftOrder = new GiftOrder();

            foodOrder.ProcessOrder();

            Console.WriteLine("-");

            giftOrder.SetIsGift(true);
            giftOrder.ProcessOrder();
            Console.ReadKey();
        }
    }
}
