using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_announcer.Magic_Replays
{
    internal class Time
    {
        public static string GetTimeString(string datei)
        {
            Date date = scDateToNDate(datei);
            return $"{date.Day}/{date.Month}/{date.Year} {date.Hour}:{date.Minute}:{date.Second}";
        }

        public static Date scDateToNDate(string date)
        {
            return new Date()
            {
                Day = date.Substring(6, 2),
                Month = date.Substring(4, 2),
                Year = date.Substring(0, 4),
                Hour = date.Substring(9, 2),
                Minute = date.Substring(11, 2),
                Second = date.Substring(13, 2)
            };
        }
    }

    class Date
    {
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Hour { get; set; }
        public string Minute { get; set; }
        public string Second { get; set; }
    }
}