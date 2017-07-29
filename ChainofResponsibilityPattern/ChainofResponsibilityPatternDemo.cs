using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern
{
    //责任链模式
    //适用性：
    //1.有多个对象可以处理一个请求，哪个对象处理该请求运行时刻自动确定。
    //2.你想在不明确接收者的情况下，向多个对象中的一个提交一个请求。
    //3.可处理一个请求的对象集合应被动态指定。
    public class ChainofResponsibilityPatternDemo
    {
        public void Test()
        {
            Approver a = new Director();
            Approver b = new VicePresident();
            Approver c = new President();
            a.SetSuccessor(b);
            b.SetSuccessor(c);

            Purchase p = new Purchase(1034, 350.00, "Supplies");
            a.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            a.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");

            a.ProcessRequest(p);

            Console.ReadLine();
        }
    }
}
