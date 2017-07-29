using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorPattern
{
    public class IIteratorPatternDemo
    {
        //适用性：   
        //1．访问一个聚合对象的内容而无需暴露它的内部表示。
        //2．支持对聚合对象的多种遍历。
        //3．为遍历不同的聚合结构提供一个统一的接口(即, 支持多态迭代)。
        public void Test()
        {
            IList list = new ConcreteList();
            IIterator iIterator = list.GetIterator();
            while(iIterator.MoveNext())
            {
                Console.WriteLine($"Item is {iIterator.CurrentItem().ToString()}");
                iIterator.Next();
            }

            Console.ReadLine();
        }
    }
}
