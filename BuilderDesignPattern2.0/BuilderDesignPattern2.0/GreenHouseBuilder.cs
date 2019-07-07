using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern2._0
{
    public class GreenHouseBuilder : IHouseBuilder
    {
        private House House;
        public GreenHouseBuilder()
        {
            House = new House();
        }
        public void BuildDoor()
        {
            House.SetDoor("Green Door");
        }

        public void BuildRoof()
        {
            House.SetRoof("Green Roof");
        }

        public void BuildWalls()
        {
            House.SetWalls("Green Walls");
        }

        public void BuildWindow()
        {
            House.SetWindow("Green Windows");
        }

        public House GetHouse()
        {
            return House;
        }
    }
}
