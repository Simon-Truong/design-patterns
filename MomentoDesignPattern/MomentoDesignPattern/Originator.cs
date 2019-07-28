using System;
using System.Collections.Generic;
using System.Text;

namespace MomentoDesignPattern
{
    public class Originator
    {
        public string State { get; set; }

        public Momento SaveStateToMomento()
        {
            return new Momento(State);
        }

        public void LoadStateFromMomento(Momento momento)
        {
            State = momento.State;
        }
    }
}
