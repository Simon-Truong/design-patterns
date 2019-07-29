using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class ColleagueB : Colleague
    {
        public ColleagueB(IMediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine($"Received by ColleagueB: {message}");
        }

        public override void Send(string message)
        {
            _mediator.Send(this, message);
        }
    }
}
