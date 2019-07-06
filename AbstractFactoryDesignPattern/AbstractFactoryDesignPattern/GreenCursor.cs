using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class GreenCursor : ICursor
    {
        public string CursorDescription()
        {
            return "This cursor is green";
        }
    }
}
