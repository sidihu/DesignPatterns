using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Tank50:Tank
    {
        public override void Shot()
        {
            Console.WriteLine("T50坦克平均每秒射击5发子弹\n");
        }

        public override void Run()
        {
            Console.WriteLine("T50坦克平均每时运行30公里\n");
        }
    }
}
