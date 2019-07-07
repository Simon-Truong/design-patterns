using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern2._0
{
    public class Engineer
    {
        private IHouseBuilder HouseBuilder;
        public Engineer(IHouseBuilder houseBuilder)
        {
            HouseBuilder = houseBuilder;
        }

        public House GetHouse()
        {
            return HouseBuilder.GetHouse();
        }

        public void ConstructHouse()
        {
            HouseBuilder.BuildRoof();
            HouseBuilder.BuildWalls();
            HouseBuilder.BuildDoor();
            HouseBuilder.BuildWindow();
        }
    }
}
