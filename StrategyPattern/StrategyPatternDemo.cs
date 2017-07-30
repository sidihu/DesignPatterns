using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    //策略模式
    //适用性：
    //1.许多相关的类仅仅是行为有异。“策略”提供了一种用多个行为中的一个行为来配置一个类的方法。
    //2.需要使用一个算法的不同变体。例如，你可能会定义一些反映不同的空间/时间权衡的算法。当这些变体实现为一个算法的类层次时[H087]，可以使用策略模式。    
    //3.算法使用客户不应该知道数据。可使用策略模式以避免暴露复杂的，与算法相关的数据结构。
    //4.一个类定义了多种行为，并且这些行为在这个类的操作中以多个条件语句的形式出现。将相关的条件分支移入它们各自的Strategy类中以代替这些条件语句。
    public class StrategyPatternDemo
    {
        public void Test()
        {
            SortdList studentRecords = new SortdList();

            studentRecords.Add("Satu");
            studentRecords.Add("Jim");
            studentRecords.Add("Palo");
            studentRecords.Add("Terry");
            studentRecords.Add("Annaro");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            Console.Read();
        }
    }
}
