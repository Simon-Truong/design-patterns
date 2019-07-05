using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class Cat: Visitable
    {
        public string Name { get; set; }

        public override string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
