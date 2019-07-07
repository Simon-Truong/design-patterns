using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern2._0
{
    public class WoodHouseBuilder : IHouseBuilder
    {
        private House House;
        public WoodHouseBuilder()
        {
            House = new House();
        }
        public void BuildDoor()
        {
            House.SetDoor("Wooden Door");
        }

        public void BuildRoof()
        {
            House.SetRoof("Wooden Roof");
        }

        public void BuildWalls()
        {
            House.SetWalls("Wooden Walls");
        }

        public void BuildWindow()
        {
            House.SetWindow("Wooden Windows");
        }

        public House GetHouse()
        {
            return House;
        }
    }
}
