using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class ColleagueA : Colleague
    {
        public ColleagueA(IMediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Received by ColleagueA: {message}");
        }

        public override void Send(string message)
        {
            _mediator.Send(this, message);
        }
    }
}
