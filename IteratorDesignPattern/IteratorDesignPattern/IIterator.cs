using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDesignPattern
{
    public interface IIterator
    {
        object First();
        object Next();
        object CurrentItem();
        bool IsDone { get; }
    }
}
