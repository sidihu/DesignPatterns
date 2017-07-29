using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class NoBeatle : Participant
    {
        public NoBeatle(string name) : base(name) { }

        public override void Receive(string name, string message)
        {
            Console.WriteLine($"Get Mseeage:");
            base.Receive(name, message);
        }
    }
}
