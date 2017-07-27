using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorPattern
{
    public class ConcreteIterator:IIterator
    {
        private ConcreteList list;

        private int index;

        public ConcreteIterator(ConcreteList list)
        {
            this.list = list;
            index = 0;
        }

        public bool MoveNext()
        {
            if (index < list.Length)
                return true;
            return false;
        }

        public object CurrentItem()
        {
            return list.GetElement(index);
        }

        public void First()
        {
            index = 0;
        }

        public void Next()
        {
            if (index < list.Length)
                index++;
        }

    }
}
