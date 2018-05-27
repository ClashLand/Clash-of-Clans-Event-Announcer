using Discord;
using Discord.Commands;
using Discord.WebSocket;
using event_announcer.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace event_announcer
{
    class Program
    {
        public static DiscordSocketClient _client;
        public static SocketCommandContext Context;
        public static Config Config;
        public static string Token;
        static void Main()
        {
            Console.Title = $"ClashLand Event Announcer v{Constants.Version}";
            NativeCalls.SetWindowLong(NativeCalls.GetConsoleWindow(), -20, (int)NativeCalls.GetWindowLong(NativeCalls.GetConsoleWindow(), -20) ^ 0x80000);
            NativeCalls.SetLayeredWindowAttributes(NativeCalls.GetConsoleWindow(), 0, 217, 0x2);

            Console.SetOut(new Prefixed());
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(@"_________ .__                .__     .____                       .___");
            Console.WriteLine(@"\_   ___ \|  | _____    _____|  |__  |    |   _____    ____    __| _/");
            Console.WriteLine(@"/    \  \/|  | \__  \  /  ___/  |  \ |    |   \__  \  /    \  / __ | ");
            Console.WriteLine(@"\     \___|  |__/ __ \_\___ \|   Y  \|    |___ / __ \|   |  \/ /_/ | ");
            Console.WriteLine(@" \______  /____(____  /____  >___|  /|_______ (____  /___|  /\____ | ");
            Console.WriteLine(@"        \/          \/     \/     \/         \/    \/     \/      \/ ");
            Console.WriteLine(@"                  Clash of Clans Events Announcer                    ");
            Console.ResetColor();

            Console.WriteLine(@"ClashLand is protected by our policies, available only to our partner.");
            Console.WriteLine(@"ClashLand program is under the 'Proprietary' license.");
            Console.WriteLine(@"ClashLand is NOT affiliated to 'Supercell Oy'.");
            Console.WriteLine(@"-----------------------------------------------------");
            Config = LoadConfig();
            Token = Config.Token;
            new Program().Login().GetAwaiter().GetResult();
            _client.Ready += OnClientReady;
            Console.ReadLine();

        }
        private static Task OnClientReady()
        {
            new AutoChecker();
            return Task.CompletedTask;
        }
        public static Config LoadConfig()
        {
            Config Config = new Config();
            if (!File.Exists("Config.json"))
            {
                using (StreamWriter sw = File.CreateText("Config.json"))
                {
                    Config = new Config()
                    {
                        Prefix = "",
                        Token = "",
                    };
                    string json = JsonConvert.SerializeObject(Config);
                    sw.Write(json);
                    sw.Close();
                }
                Console.WriteLine("Fill up your 'Config.json' file.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                string json = File.ReadAllText("Config.json");
                if (json == "" || json == "{}" || json == "{\"BotToken\":\"\",\"BotPrefix\":\"\"}")
                {
                    Console.WriteLine("Fill up your 'Config.json' file.");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Config = JsonConvert.DeserializeObject<Config>(json);
                }
            }
            return Config;
        }
        public async Task Login()
        {

            _client = new DiscordSocketClient(new DiscordSocketConfig()
            {
                LogLevel = LogSeverity.Info,
            });
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Discord Channel identified");
                Console.ResetColor();
                await _client.LoginAsync(TokenType.Bot, Token);
                await _client.StartAsync();
                _client.Log += LogInConsole;
                _client.MessageReceived += HandleMessage;
                _client.MessageUpdated += HandleEditedMessage;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured while connecting to your bot.\n{ex.Message}");
            }
        }

        private Task HandleEditedMessage(Cacheable<IMessage, ulong> IMsg, SocketMessage rawMessage, ISocketMessageChannel Channel)
        {
            try
            {
                SocketUserMessage message = rawMessage as SocketUserMessage;
                string text = message.Content;
                if (text.StartsWith(Config.Prefix))
                {
                    CommandHandler.Handle(rawMessage, text.Remove(0, 1));
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
            }
            return Task.CompletedTask;
        }

        private static Task HandleMessage(SocketMessage rawMessage)
        {
            try
            {
                SocketUserMessage message = rawMessage as SocketUserMessage;
                string text = message.Content;
                if (text.StartsWith(Config.Prefix))
                {
                    CommandHandler.Handle(rawMessage, text.Remove(0, 1));
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
            }
            return Task.CompletedTask;
        }

        private static Task LogInConsole(LogMessage msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(msg.Message);
            Console.ResetColor();
            return Task.CompletedTask;
        }
    }
}
