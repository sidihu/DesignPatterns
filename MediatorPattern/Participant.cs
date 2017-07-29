using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Participant
    {
        public string name { get; set; }
        public Chatroom room { get; set; }

        public Participant(string name)
        {
            this.name = name;
        }

        public void Send(string to,string mesage)
        {
            room.Send(name,to, mesage);
        }

        public virtual void Receive(string from,string message)
        {
            Console.WriteLine($"from {from} to {name} Receive:{message} ");
        }
        
    }
}
