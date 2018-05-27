using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace event_announcer
{
    public class CommandHandler
    {
        public static void Handle(SocketMessage message, string command)
        {
            string[] CommandArray = Regex.Split(command, " ");
            if (CommandFactory.Commands.ContainsKey(CommandArray.FirstOrDefault()))
            {
                Command Command = Activator.CreateInstance(CommandFactory.Commands[command]) as Command;
                Command.Process(message);
            }
        }
    }
}
