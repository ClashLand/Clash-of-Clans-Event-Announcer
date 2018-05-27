using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace event_announcer
{
    internal class Constants
    {
        internal const string eventsURL = "https://s3.amazonaws.com/magic-replays/replay.json";
        internal const string eventsAssetsURL = "https://event-assets.clashofclans.com";
        public static string Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

    }
}
