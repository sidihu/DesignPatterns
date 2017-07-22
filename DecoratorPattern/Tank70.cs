using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Tank70 : Tank
    {
        public override void Shot()
        {
            Console.WriteLine("T70坦克平均每秒射击10发子弹");
        }

        public override void Run()
        {
            Console.WriteLine("T70坦克平均每时运行35公里");
        }
    }
}
