using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    //原型模式(Prototype)适用性：
    //1．当一个系统应该独立于它的产品创建，构成和表示时；
    //2．当要实例化的类是在运行时刻指定时，例如，通过动态装载；
    //3．为了避免创建一个与产品类层次平行的工厂类层次时；
    //4．当一个类的实例只能有几个不同状态组合中的一种时。建立相应数目的原型并克隆它们可能比每次用合适的状态手工实例化该类更方便一些。
    public class PrototypePatternDemo
    {
        public void test()
        {
            NormalActor normal1 = new NormalActorA().ShallowClone();
            NormalActor normal2 = new NormalActorA().DeepClone();
             
            Console.Write($"NormalActorA ShallowClone i is {normal1.i.ToString()}\n");
            Console.Write($"NormalActorA DeepClone i is {normal2.i.ToString()}\n");
            normal1.i = 2;
            Console.Write($"NormalActorA ShallowClone i is {normal1.i.ToString()}\n");
            Console.Write($"NormalActorA DeepClone i is {normal2.i.ToString()}\n");
            Console.ReadLine();
        }
    }
}
