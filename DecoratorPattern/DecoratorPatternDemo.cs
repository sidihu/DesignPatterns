using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DecoratorPatternDemo
    {
        public void Test()
        {
            Tank t = new Tank50();

            Decorator d = new Decorator(t);
            d.Shot();
            d.Run();

            Decorator da = new DecoratorA(d);
            da.Shot();
            da.Run();

            Decorator db = new DecoratorB(da);
            db.Shot();
            db.Run();

            Decorator dc = new DecoratorC(db);
            dc.Shot();
            dc.Run();

            Console.ReadLine();
        }
    }
}
