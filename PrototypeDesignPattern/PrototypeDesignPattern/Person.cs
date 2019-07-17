using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
        public Person(string name, int age, string profession)
        {
            Name = name;
            Age = age;
            Profession = profession;
        }
        public ICloneable Clone()
        {
            return MemberwiseClone() as ICloneable;
        }
        public void GetDetails()
        {
            Console.WriteLine($"My name is {Name}\nI am {Age} years old\nI am a {Profession}");
        }
    }
}
