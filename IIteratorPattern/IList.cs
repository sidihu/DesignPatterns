using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIteratorPattern
{
    public interface IList
    {
        IIterator GetIterator();
    }
}
