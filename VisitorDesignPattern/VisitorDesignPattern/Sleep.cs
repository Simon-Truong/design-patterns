using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class Sleep : IVisitor
    {
        public string Visit(Cat cat)
        {
            return "Cat is sleeping";
        }

        public string Visit(Dog dog)
        {
            return "Dog is sleeping";
        }

        public string Visit(Bird bird)
        {
            return "Bird is sleeping";
        }
    }
}
