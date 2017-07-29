using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Subject
    {
        public decimal money { get; set; }

        private List<IObserverAccount> list = new List<IObserverAccount>();

        public Subject(decimal money)
        {
            this.money = money;
        }

        public void WithDraw()
        {
            foreach (IObserverAccount o in list)
            {
                o.Send(this);
            }

            Console.ReadLine();
        }

        public void AddIObserverAccount(IObserverAccount observerAccount)
        {
            list.Add(observerAccount);
        }

        public void RemoveIObserverAccount(IObserverAccount observerAccount)
        {
            list.Remove(observerAccount);
        }

        public void WithDrawV2()
        {
            OnNotifyChange();
        }

        private void OnNotifyChange()
        {
            if (NotifyEvent != null)
            {
                NotifyEvent(this);
            }
        }

        //事件方式
        public delegate void NotifyEventHandler(object sender);
        public event NotifyEventHandler NotifyEvent;

    }
}
