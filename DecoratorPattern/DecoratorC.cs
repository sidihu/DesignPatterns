using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DecoratorC : Decorator
    {
        private Tank tank;
        public DecoratorC(Tank tank):base(tank)
        {
            this.tank = tank;
        }
        public override void Shot()
        {
            Console.Write($"{this.GetType().Name} have C\n");
            base.Shot();
        }

        public override void Run()
        {
            base.Run();
        }

    }
}
