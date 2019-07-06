using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class GreenButton : IButton
    {
        public string ClickButton()
        {
            return "Clicked on green button";
        }
    }
}
