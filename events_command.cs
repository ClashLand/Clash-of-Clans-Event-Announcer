using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace event_announcer
{
    public class Events_command : Command
    {
        public new string Summary = "Shows the events info";
        public override void Process(SocketMessage message)
        {
            new Thread(() =>
            {
                AutoChecker.SendEventsInfo();
            }).Start();
        }
    }
}
