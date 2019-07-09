using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class DecreaseTvVolume : ICommand
    {
        private readonly Television _television;
        public DecreaseTvVolume(Television television)
        {
            _television = television;
        }
        public string Execute()
        {
            return _television.DecreaseVolume();
        }
    }
}
