using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class Mediator : IMediator
    {
        private Colleague _colleague1;
        private Colleague _colleague2;

        public void SetColleague1(Colleague colleague)
        {
            _colleague1 = colleague;
        }
        public void SetColleague2(Colleague colleague)
        {
            _colleague2 = colleague;
        }

        public void Send(Colleague sender, string message)
        {
            if (sender == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else
            {
                _colleague1.Notify(message);
            }
        }
    }
}
