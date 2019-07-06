using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class RedButton : IButton
    {
        public string ClickButton()
        {
            return "Clicked on red button";
        }
    }
}
