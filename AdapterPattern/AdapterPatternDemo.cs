using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //适用性：
    //1．系统需要使用现有的类，而此类的接口不符合系统的需要。
    //2．想要建立一个可以重复使用的类，用于与一些彼此之间没有太大关联的一些类，包括一些可能在将来引进的类一起工作。这些源类不一定有很复杂的接口。
    //3．（对对象适配器而言）在设计里，需要改变多个已有子类的接口，如果使用类的适配器模式，就要针对每一个子类做一个适配器，而这不太实际。
    public class AdapterPatternDemo
    {
        public void Test()
        {
            //Adapter adapter = new Adapter();
            //adapter.Push("aaaa");
            //adapter.Push("bbbbb");
            
            //Console.Write($"adapter's length is {adapter.Count()}\n");
            //adapter.Pop();
            //Console.Write($"after Pop adapter's length is {adapter.Count()}\n");
            //Console.Write($"adapter's Peek is {adapter.Peek().ToString()}\n");
            //Console.ReadLine();


            AdapterV2 adapterV2 = new AdapterV2();
            adapterV2.Push("cccc");
            adapterV2.Push("dddd");
            adapterV2.Push("eeee");
            Console.Write($"adapterV2's length is {adapterV2.Count}\n");
            adapterV2.Pop();
            Console.Write($"after Pop adapterV2's length is {adapterV2.Count}\n");
            Console.Write($"adapterV2's Peek is {adapterV2.Peek().ToString()}\n");
            Console.ReadLine();
        }
    }
}
