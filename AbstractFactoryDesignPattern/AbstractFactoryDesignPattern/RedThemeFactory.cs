using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class RedThemeFactory : ThemeAbstractFactory
    {
        public IButton getButton()
        {
            return new RedButton();
        }

        public ICursor getCursor()
        {
            return new RedCursor();
        }

        public IWallpaper getWallPaper()
        {
            return new RedWallpaper();
        }
    }
}
