using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{//    Factory Method 模式的几个要点：
//Factory Method模式主要用于隔离类对象的使用者和具体类型之间的耦合关系。面对一个经常变化的具体类型，紧耦合关系会导致软件的脆弱。
//Factory Method模式通过面向对象的手法，将所要创建的具体对象工作延迟到子类，从而实现一种扩展（而非更改）的策略，较好地解决了这种紧耦合关系。
//Factory Mehtod模式解决"单个对象"的需求变化，AbstractFactory模式解决"系列对象"的需求变化，Builder模式解决"对象部分"的需求变化。
//    Factory Method 模式的几个要点：
//Factory Method模式主要用于隔离类对象的使用者和具体类型之间的耦合关系。面对一个经常变化的具体类型，紧耦合关系会导致软件的脆弱。
//Factory Method模式通过面向对象的手法，将所要创建的具体对象工作延迟到子类，从而实现一种扩展（而非更改）的策略，较好地解决了这种紧耦合关系。
//Factory Mehtod模式解决"单个对象"的需求变化，AbstractFactory模式解决"系列对象"的需求变化，Builder模式解决"对象部分"的需求变化。
    public class FactoryMethodDemo
    {
        public void test()
        {
            Console.Write($"choice car 1 is Benz and 2 is BMW \n");
            string s = Console.ReadLine();
            CarFactory cf = null;
            Car car = null;
            if (s == "1")
                cf = new BensFactory();
            else
                cf = new BMWFactory();
            car = cf.CreateCar();
            car.StartUp();
            car.Run();
            car.Stop();
            Console.ReadLine();
        }
    }
}
