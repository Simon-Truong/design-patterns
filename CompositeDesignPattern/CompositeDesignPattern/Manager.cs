using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    public class Manager : IEmployee
    {
        private List<IEmployee> Subordinates;
        private int Id;
        private string Name;

        public Manager(int id, string name)
        {
            Id = id;
            Name = name;
            Subordinates = new List<IEmployee>();
        }
        public void PrintDetails()
        {
            Console.WriteLine($"My name is {Name}, and my employee number is {Id}");
            Console.WriteLine($"And I manage: ");
            foreach (IEmployee subordinate in Subordinates)
            {
                subordinate.PrintDetails();
            }
        }

        public void AddSubordinate(IEmployee employee)
        {
            Subordinates.Add(employee);
        }
    }
}
