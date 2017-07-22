using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Decorator : Tank
    {
        private Tank tank;

       public Decorator(Tank tank)
        {
            this.tank = tank;
        }

        public override void Shot()
        {
            this.tank.Shot();
        }

        public override void Run()
        {
            this.tank.Run();
        }
    }
}
