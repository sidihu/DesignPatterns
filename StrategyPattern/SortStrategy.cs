using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class SortStrategy
    {
        public abstract void Sort(ArrayList list);
    }
}
