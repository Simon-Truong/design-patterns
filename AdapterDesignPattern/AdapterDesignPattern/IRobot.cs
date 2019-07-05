using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public interface IRobot
    {
        string Recharge();
        string Roll();
        string SpeakBinary();
    }
}
