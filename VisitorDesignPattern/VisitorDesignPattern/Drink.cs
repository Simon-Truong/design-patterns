using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class Drink : IVisitor
    {
        public string Visit(Cat cat)
        {
            return "Cat is drinking";
        }

        public string Visit(Dog dog)
        {
            return "Dog is drinking";
        }

        public string Visit(Bird bird)
        {
            return "Bird is drinking";
        }
    }
}
