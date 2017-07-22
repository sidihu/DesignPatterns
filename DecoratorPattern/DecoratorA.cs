using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DecoratorA: Decorator
    {
        private Tank tank;

        public DecoratorA(Tank tank):base(tank)
        {
            this.tank = tank;
        }

        public override void Shot()
        {
            Console.Write($"{this.GetType().Name} have A\n");
            base.Shot();
        }

        public override void Run()
        {
            base.Run();
        }
    }
}
