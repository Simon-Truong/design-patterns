using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class RedWallpaper : IWallpaper
    {
        public string WallpaperDescription()
        {
            return "This is a red wallpaper";
        }
    }
}
