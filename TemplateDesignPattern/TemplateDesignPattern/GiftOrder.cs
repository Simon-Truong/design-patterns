using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public class GiftOrder : Order
    {
        public override void ChooseProducts()
        {
            Console.WriteLine("Choosing birthday cake");
        }

        public override void DeliverProducts()
        {
            Console.WriteLine("Delivering birthday cake");
        }

        public override void PayProducts()
        {
            Console.WriteLine("Paying for the birthday cake");
        }
    }
}
