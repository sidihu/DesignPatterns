using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SortdList
    {
        private ArrayList list = new ArrayList();
        private SortStrategy sortstrategy;  //对象组合
        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this.sortstrategy = sortstrategy;
        }
        public void Add(string name)
        {
            list.Add(name);
        }
        public void Sort()
        {
            sortstrategy.Sort(list);
            //Display results 
            foreach (string name in list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
