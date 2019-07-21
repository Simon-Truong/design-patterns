using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class Pizza : IPizza
    {
        public void GetPizza()
        {
            Console.WriteLine("Getting Pizza");
        }
    }
}
