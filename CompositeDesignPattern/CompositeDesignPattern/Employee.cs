using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class Employee : IEmployee
    {
        private int Id;
        private string Name;

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"My name is {Name}, and my employee number is {Id}");
            Console.WriteLine("----------------------------------------------");
        }
    }
}
