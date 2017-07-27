using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorPattern
{
    public class IIteratorPatternDemo
    {
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
