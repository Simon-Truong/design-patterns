using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class TurnTvOff : ICommand
    {
        private readonly Television _television;

        public TurnTvOff(Television television)
        {
            _television = television;
        }
        public string Execute()
        {
            return _television.TurnOff();
        }
    }
}
