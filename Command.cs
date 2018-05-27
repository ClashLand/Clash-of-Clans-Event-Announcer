using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_announcer
{
    public class Command
    {
        public string Summary = "";
        public virtual void Process(SocketMessage message)
        {

        }
    }
}