using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class PersonDeep : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
        public Pet Pet { get; set; }
        public PersonDeep(string name, int age, string profession, Pet pet)
        {
            Name = name;
            Age = age;
            Profession = profession;
            Pet = pet;
        }
        public ICloneable Clone()
        {
            PersonDeep newObj = MemberwiseClone() as PersonDeep;
            newObj.Pet = newObj.Pet.Clone() as Pet;
            return newObj as ICloneable;
        }
        public void GetDetails()
        {
            Console.WriteLine($"My name is {Name}\nI am {Age} years old\nI am a {Profession}");
        }
    }
}
