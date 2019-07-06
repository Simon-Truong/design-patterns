using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class BlueThemeFactory : ThemeAbstractFactory
    {
        public IButton getButton()
        {
            return new BlueButton();
        }

        public ICursor getCursor()
        {
            return new BlueCursor();
        }

        public IWallpaper getWallPaper()
        {
            return new BlueWallpaper();
        }
    }
}
