using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class HouseBuilder:Builder
    {
        private House house = new House();

        public override void BuildDoor()
        {
            house.Door = "BuildDoor";
        }

        public override void BuilderWindow()
        {
            house.Window = "BuilderWindow";
        }

        public override void BuildWall()
        {
            house.Wall = "BuildWall";
        }

        public override void BuildFloor()
        {
            house.Floor = "BuildFloor";
        }

        public override void BuildHouseCeiling()
        {
            house.HouseCeiling = "BuildHouseCeiling";
        }

        public override House GetHouse()
        {
            return house;
        }
    }
}
