using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    //中介者模式
    //适用性：
    //1.一组对象以定义良好但是复杂的方式进行通信。产生的相互依赖关系结构混乱且难以理解。
    //2.一个对象引用其他很多对象并且直接与这些对象通信，导致难以复用该对象。
    //3.想定制一个分布在多个类中的行为，而又不想生成太多的子类。
    public class MediatorPatternDemo
    {
        public void Test()
        {
            Chatroom room = new Chatroom();
            Participant p1 = new Beatle("A");
            Participant p2 = new NoBeatle("B");
            Participant p3 = new NoBeatle("C");
            room.Register(p1);
            room.Register(p2);
            room.Register(p3);
            p1.Send("B", "hello B");
            p1.Send("C", "hello C");
            p2.Send("A", "hello A");
            p3.Send("A", "hello A");
            p3.Send("B", "hello B");
            Console.ReadLine();
        } 
    }
}
