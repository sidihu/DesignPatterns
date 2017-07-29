using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ObserverPattern.Subject;

namespace ObserverPattern
{
    public class ObserverPatternDemo
    {
        //适用性：
        //1．当一个抽象模型有两个方面, 其中一个方面依赖于另一方面。将这二者封装在独立的对象中以使它们可以各自独立地改变和复用。
        //2．当对一个对象的改变需要同时改变其它对象, 而不知道具体有多少对象有待改变。
        //3．当一个对象必须通知其它对象，而它又不能假定其它对象是谁。换言之, 你不希望这些对象是紧密耦合的。
        public void Test()
        {
            //推模式
            //Subject subject = new BankAccount(100);
            //IObserverAccount a = new Emailer("email");
            //IObserverAccount b = new Mobile(15857187907);
            //subject.AddIObserverAccount(a);
            //subject.AddIObserverAccount(b);
            //subject.WithDraw();

            //拉模式
            //Subject subject = new BankAccount(100);
            //IObserverAccount a = new Emailer("email",subject);
            //IObserverAccount b = new Mobile(15857187907, subject);
            //subject.AddIObserverAccount(a);
            //subject.AddIObserverAccount(b);
            //subject.WithDraw();


            //委托模式
            Subject subject = new BankAccount(100);
            IObserverAccount a = new Emailer("email");
            IObserverAccount b = new Mobile(15857187907);
            subject.NotifyEvent += new NotifyEventHandler(a.Send);
            subject.NotifyEvent += new NotifyEventHandler(b.Send);
            subject.WithDrawV2();

            Console.ReadLine();
        }
    }
}
