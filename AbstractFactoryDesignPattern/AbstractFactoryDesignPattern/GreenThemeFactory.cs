using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class GreenThemeFactory : ThemeAbstractFactory
    {
        public IButton getButton()
        {
            return new GreenButton();
        }

        public ICursor getCursor()
        {
            return new GreenCursor();
        }

        public IWallpaper getWallPaper()
        {
            return new GreenWallpaper();
        }
    }
}
