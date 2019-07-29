using System;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new Mediator();

            Colleague colleagueA = new ColleagueA(mediator);
            Colleague colleagueB = new ColleagueB(mediator);

            mediator.SetColleague1(colleagueA);
            mediator.SetColleague2(colleagueB);

            colleagueA.Send("Message from ColleagueA");
            colleagueB.Send("Message from ColleagueB");

            Console.Read();
        }
    }
}
