using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorPattern
{
    public class ConcreteList:IList
    {
        int[] list;

        public ConcreteList()
        {
            list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        public IIterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Length
        {
            get { return list.Length; }
        }

        public int GetElement(int index)
        {
            return list[index];
        }
    }
}

