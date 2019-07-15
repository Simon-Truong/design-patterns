using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern
{
    public class ShallowDetails : Cloneable
    {
        public ShallowDetails(int id, string name, int age, Address address) : base(id, name, age, address)
        {
        }

        public override Cloneable Clone()
        {
            return MemberwiseClone() as Cloneable;
        }
    }
}
