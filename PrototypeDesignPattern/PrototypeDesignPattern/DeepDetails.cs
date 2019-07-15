using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern
{
    public class DeepDetails : Cloneable
    {
        public DeepDetails(int id, string name, int age, Address address) : base(id, name, age, address)
        {
        }

        public override Cloneable Clone()
        {
            Cloneable newDeepDetails = MemberwiseClone() as Cloneable;
        }
    }
}
