using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Chatroom:AbstractChatroom
    {
        private Hashtable table = new Hashtable();

        public override void Register(Participant participant)
        {
            if (!table.ContainsKey(participant.name))
            {
                table.Add(participant.name, participant);
                participant.room = this;
            }
        }

        public override void Send(string from, string to, string message)
        {
            if(table.ContainsKey(to))
            {
                Participant p = table[to] as Participant;
                p.Receive(from,message);
            }
        }
    }
}
