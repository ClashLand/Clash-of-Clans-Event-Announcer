using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_announcer
{
    public class CommandFactory
    {
        public static Dictionary<string, Type> Commands = new Dictionary<string, Type>
        {
            {"events" , typeof(Events_command)},
        };
    }
}
