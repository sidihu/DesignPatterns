using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Emailer: IObserverAccount
    {
        private string email;
        public Emailer(string email)
        {
            this.email = email;
        }

        //拉模式
        private Subject subject { get; set; }
        public Emailer(string email, Subject subject)
        {
            this.email = email;
            this.subject = subject;
        }

        public void Send(Subject subject)
        {
            Console.WriteLine($"Send Email to {email} with {subject.money}");
        }

        public void Send(object subject)
        {
            if (subject is Subject)
            {
                Subject o = subject as Subject;
                Console.WriteLine($"Send Email to {email} with {o.money}");
            }
        }
    }
}
