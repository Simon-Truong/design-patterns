using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern
{
    public interface IAggregate
    {
        Iterator CreateIterator();
    }
}
