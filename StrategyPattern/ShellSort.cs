using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ShellSort : SortStrategy
    {
        public override void Sort(System.Collections.ArrayList list)
        {
            list.Sort(); //no-implement
            Console.WriteLine("ShellSorted List");

        }
    }
}
