using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class Bread : IBread
    {
        public void GetBread()
        {
            Console.WriteLine("Getting Bread");
        }
    }
}
