using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public abstract class Order
    {
        private bool IsGift = false;

        public abstract void ChooseProducts();

        public abstract void PayProducts();

        public abstract void DeliverProducts();

        public void SetIsGift(bool input)
        {
            IsGift = input;
        }

        public void WrapProducts()
        {
            Console.WriteLine("Wrapping products");
        }

        public void ProcessOrder()
        {
            ChooseProducts();
            PayProducts();
            if(IsGift == true)
            {
                WrapProducts();
            }
            DeliverProducts();
        }
    }
}
