using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class TvRemote : IInvoker
    {
        private ICommand _command;
        public TvRemote(ICommand command)
        {
            _command = command;
        }
        public string ExecuteCommand()
        {
            return _command.Execute();
        }
    }
}
