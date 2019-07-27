using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern
{
    public interface IFactory
    {
        IShape GetShape(string shape);
        int GetCount();
    }
}
