using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public interface IMediator
    {
        void Send(Colleague colleague, string message);
        void SetColleague1(Colleague colleague);
        void SetColleague2(Colleague colleague);
    }
}
