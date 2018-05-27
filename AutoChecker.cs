using Discord;
using event_announcer.Magic_Replays;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace event_announcer
{
    public class AutoChecker
    {
        public static System.Timers.Timer Timer;
        public static System.Timers.Timer FirstTimer;
        public static bool eventInfoChanged;
        public AutoChecker(bool firstTime = false)
        {
            Check();
            Timer = new System.Timers.Timer();
            Timer.Start();
            Timer.Interval = 600000;
            Timer.Elapsed += CheckForChanges;
        }

        private void Check()
        {
            FirstTimer = new System.Timers.Timer(5000);
            FirstTimer.Start();
            FirstTimer.Elapsed += FirstTimeCheck;
        }

        private void FirstTimeCheck(object sender, ElapsedEventArgs e)
        {
            FirstTimer.Stop();
            Thread E = new Thread(() =>
            {
                SendEventsInfo();
            });
            E.Start();
        }

        private void CheckForChanges(object sender, ElapsedEventArgs e)
        {
            Thread E = new Thread(() =>
            {
                SendEventsInfo();
            });
            //E.Start();

        }

        public static void SendEventsInfo()
        {
            WebClient client = new WebClient();
            MagicReplays magicReplays = MagicReplays.FromJson(client.DownloadString(Constants.eventsURL));

            foreach (var currentEvent in magicReplays.Calendar.Events)
            {
                var json = JsonConvert.SerializeObject(currentEvent);
                
                EmbedBuilder embed = new EmbedBuilder();
                embed.Color = Color.Green;
                embed.Title = $"Clash Of Clans Events Info";
                embed.Url = ("https://github.com/ClashLand");
                embed.AddField($"Notification", $"{currentEvent.NotificationTid}");
                embed.AddField("Visible Time", Time.GetTimeString(currentEvent.VisibleTime));
                embed.AddField("Start Time", Time.GetTimeString(currentEvent.StartTime));
                embed.AddField("End Time", Time.GetTimeString(currentEvent.EndTime));
                if (currentEvent.ImageFile != null)
                {
                    embed.WithImageUrl (Constants.eventsAssetsURL + currentEvent.ImageFile.Path);
                }
                embed.Timestamp = DateTimeOffset.UtcNow;
                var channel = Program._client.Guilds.FirstOrDefault(x => x.Name.ToLower() == Program.Config.ServerName.ToLower()).TextChannels.FirstOrDefault(x => x.Name.ToLower() == Program.Config.ChannelName.ToLower()) as IMessageChannel;
                channel.SendMessageAsync("", false, embed);
            } 
        }
    }
}