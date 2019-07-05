using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class Adapter : IAnimal
    {
        private IRobot _robot;
        public Adapter(IRobot robot)
        {
            _robot = robot;
        }
        public string Eat()
        {
            return _robot.Recharge();
        }

        public string Talk()
        {
            return _robot.SpeakBinary();
        }

        public string Walk()
        {
            return _robot.Roll();
        }
    }
}
