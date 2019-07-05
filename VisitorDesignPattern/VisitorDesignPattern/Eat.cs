using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class Eat : IVisitor
    {
        public string Visit(Cat cat)
        {
            return "Cat is eating";
        }

        public string Visit(Dog dog)
        {
            return "Dog is eating";
        }

        public string Visit(Bird bird)
        {
            return "Bird is eating";
        }
    }
}
