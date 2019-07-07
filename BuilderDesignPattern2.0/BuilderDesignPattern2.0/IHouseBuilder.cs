using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern2._0
{
    public interface IHouseBuilder
    {
        void BuildRoof();
        void BuildWalls();
        void BuildDoor();
        void BuildWindow();
        House GetHouse();
    }
}
