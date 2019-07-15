using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern
{
    public abstract class Cloneable
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public int Age{ get; set;}
        public Address Address{ get; set;}
        public Cloneable(int id, string name, int age, Address address)
        {
            Id = id;
            Name = name;
            Age = age;
            Address = address;
            
        }
        public abstract Cloneable Clone();
    }
}
