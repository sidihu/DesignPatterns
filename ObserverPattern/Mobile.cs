using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Mobile: IObserverAccount
    {
        private long mobile { get; set; }

        public Mobile(long mobile)
        {
            this.mobile = mobile;
        }

        //拉模式
        private Subject subject { get; set; }
        public Mobile(long mobile, Subject subject)
        {
            this.mobile = mobile;
            this.subject = subject;
        }

        public void Send(Subject subject)
        {
            Console.WriteLine($"Send SMS to {mobile} with {subject.money}");
        }

        public void Send(object subject)
        {
            if (subject is Subject)
            {
                Subject o = subject as Subject;
                Console.WriteLine($"Send Email to {mobile} with {o.money}");
            }
        }
    }
}
