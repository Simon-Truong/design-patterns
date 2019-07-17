using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Pet : ICloneable
    {
        public string Name;
        public string Type;
        public Pet(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public ICloneable Clone()
        {
            return MemberwiseClone() as ICloneable;
        }

        public void GetDetails()
        {
            Console.WriteLine($"My name is {Name} and I am a {Type}");
        }

    }
}
