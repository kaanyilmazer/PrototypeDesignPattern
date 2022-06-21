using PrototypeDesignPattern1.PrototypeDesignPattern;
using System;
using System.Collections.Generic;

namespace PrototypeDesignPattern1
{
    class Program
    {
        static void Main(string[] args)
        {

            var dailyMeetingMorning = new DailyMeeting()
            {
                StartTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 02:00")),
                EndTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 08:15")),
                Location = "İstanbul",
                Materials = new List<String>
                {
                    "Laptop",
                    "NotDefteri",
                    "Sunum Tahtası"
                },
                Participants = new List<string>
                {
                    "Kaan",
                    "Hande",
                    "Mehmet"
                },
                OrderSummary = "Toplantı Konusu Şirket Gelişimi Olacaktır."

        };

            var dailyMeetingNoon = dailyMeetingMorning.Clone();
            dailyMeetingNoon.StartTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 10:00"));
            dailyMeetingNoon.EndTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 10:30"));

            var dailyMeetingNight = dailyMeetingMorning.Clone();
            dailyMeetingNight.StartTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 20:30"));
            dailyMeetingNight.EndTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 21:30"));

            Console.WriteLine(string.Format("Sabah Oturumu : {0}-{1}", dailyMeetingMorning.StartTime, dailyMeetingMorning.EndTime));
            Console.WriteLine(string.Format("Oglen Oturumu : {0}-{1}", dailyMeetingNoon.StartTime, dailyMeetingNoon.EndTime));
            Console.WriteLine(string.Format("Aksam Oturumu : {0}-{1}", dailyMeetingNight.StartTime, dailyMeetingNight.EndTime));

            Console.ReadKey();
        }
    }
}