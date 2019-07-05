using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class Singleton
    {
        private static Singleton _singleton;
        private int _count = 0;
        private Singleton() {
            Console.WriteLine("Making new Singleton");
        }
        public static Singleton getSingleton
        {
            get
            {
                if (_singleton == null)
                {
                    _singleton = new Singleton();
                }

                Console.WriteLine("Returning Singleton");
                return _singleton;
            }
        }
        public void Count()
        {
            _count++;
            Console.WriteLine(_count);
        }
    }
}
