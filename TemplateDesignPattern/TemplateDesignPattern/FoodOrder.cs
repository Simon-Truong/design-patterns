using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public class FoodOrder : Order
    {
        public override void ChooseProducts()
        {
            Console.WriteLine("Choosing some meat and vegetables");
        }

        public override void DeliverProducts()
        {
            Console.WriteLine("Delivering meat and vegetables");
        }

        public override void PayProducts()
        {
            Console.WriteLine("Paying for the meat and vegetables");
        }
    }
}
