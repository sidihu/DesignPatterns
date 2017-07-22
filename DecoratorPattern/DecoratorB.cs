using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DecoratorB:Decorator
    {
        private Tank tank;
        public DecoratorB(Tank tank):base(tank)
        {
            this.tank = tank; 
        }
        public override void Shot()
        {
            Console.Write($"{this.GetType().Name} have B\n");
            base.Shot();
        }

        public override void Run()
        {
            base.Run();
        }

    }
}
