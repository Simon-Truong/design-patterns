using System;

namespace MomentoDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();

            originator.State = "State #1";
            careTaker.Add(originator.SaveStateToMomento());

            originator.State = "State #2";
            careTaker.Add(originator.SaveStateToMomento());

            originator.State = "State #3";
            careTaker.Add(originator.SaveStateToMomento());

            Console.WriteLine(originator.State);

            originator.LoadStateFromMomento(careTaker.Get(1));

            Console.WriteLine(originator.State);
            Console.ReadLine();
        }
    }
}
