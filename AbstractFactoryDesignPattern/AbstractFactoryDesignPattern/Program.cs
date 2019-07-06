using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GreenThemeFactory greenTheme = new GreenThemeFactory();
            RedThemeFactory redTheme = new RedThemeFactory();
            BlueThemeFactory blueTheme = new BlueThemeFactory();

            Console.WriteLine(greenTheme.getButton().ClickButton());
            Console.WriteLine(greenTheme.getCursor().CursorDescription());
            Console.WriteLine(greenTheme.getWallPaper().WallpaperDescription());

            Console.WriteLine(redTheme.getButton().ClickButton());
            Console.WriteLine(redTheme.getCursor().CursorDescription());
            Console.WriteLine(redTheme.getWallPaper().WallpaperDescription());

            Console.WriteLine(blueTheme.getButton().ClickButton());
            Console.WriteLine(blueTheme.getCursor().CursorDescription());
            Console.WriteLine(blueTheme.getWallPaper().WallpaperDescription());

            Console.ReadKey();
        }
    }
}
