using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObserverAccount
    {
        void Send(Subject subject);

        void Send(object subject);
    }
}
