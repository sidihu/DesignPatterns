using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Designer
    {
        public void Commond(Builder houseBuilder)
        {
            houseBuilder.BuildDoor();
            houseBuilder.BuilderWindow();
            houseBuilder.BuildFloor();
            houseBuilder.BuildHouseCeiling();
            houseBuilder.BuildWall();
        }
    }
}
