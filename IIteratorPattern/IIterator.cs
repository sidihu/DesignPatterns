using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorPattern
{
    public interface IIterator
    {
        bool MoveNext();

        Object CurrentItem();

        void First();

        void Next();

    }
}
