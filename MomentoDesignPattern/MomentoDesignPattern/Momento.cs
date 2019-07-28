using System;
using System.Collections.Generic;
using System.Text;

namespace MomentoDesignPattern
{
    public class Momento
    {
        public string State { get; set; }

        public Momento(string state)
        {
            State = state;
        }
    }
}
