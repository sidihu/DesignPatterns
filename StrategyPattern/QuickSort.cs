using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class QuickSort : SortStrategy
    {
        public override void Sort(System.Collections.ArrayList list)
        {
            list.Sort(); //Default is Quicksort
            Console.WriteLine("QuickSorted List");
        }
    }
}
