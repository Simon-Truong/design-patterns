using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern2._0
{
    public class House
    {
        private string Roof;
        private string Walls;
        private string Door;
        private string Window;

        public void SetRoof(string roof)
        {
            Roof = roof;
        }

        public string GetRoof()
        {
            return Roof;
        }

        public void SetWalls(string walls)
        {
            Walls = walls;
        }

        public string GetWalls()
        {
            return Walls;
        }

        public void SetDoor(string door)
        {
            Door = door;
        }

        public string GetDoor()
        {
            return Door;
        }

        public void SetWindow(string window)
        {
            Window = window;
        }

        public string GetWindow()
        {
            return Window;
        }
    }
}
