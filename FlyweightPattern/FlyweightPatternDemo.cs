using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    //适用性：   
    //当以下所有的条件都满足时，可以考虑使用享元模式：
    //1、   一个系统有大量的对象。
    //2、   这些对象耗费大量的内存。
    //3、   这些对象的状态中的大部分都可以外部化。
    //4、   这些对象可以按照内蕴状态分成很多的组，当把外蕴对象从对象中剔除时，每一个组都可以仅用一个对象代替。
    //5、   软件系统不依赖于这些对象的身份，换言之，这些对象可以是不可分辨的。
    public class FlyweightPatternDemo
    {
        public void Test()
        {
            CharactorFactory factory = new CharactorFactory();

            // Charactor "A"
            CharactorA ca = (CharactorA)factory.GetCharactor("A");
            ca.SetPointSize(12);
            ca.Display();

            // Charactor "B"
            CharactorB cb = (CharactorB)factory.GetCharactor("B");
            cb.SetPointSize(10);
            cb.Display();

            // Charactor "C"
            CharactorC cc = (CharactorC)factory.GetCharactor("C");
            cc.SetPointSize(14);
            cc.Display();

            Console.ReadLine();
        }
    }
}
