using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
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
