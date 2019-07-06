using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class RedCursor : ICursor
    {
        public string CursorDescription()
        {
            return "This cursor is red";
        }
    }
}
