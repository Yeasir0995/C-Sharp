using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCode
{
    class GameCode
    {
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 120;
            const int SecondsPerMinute = 60;
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;
            {
                Console.WriteLine("Minutes Played: " + minutesPlayed);
                Console.WriteLine("Seconds Played: " + secondsPlayed);
            }
            
        }
    }
}
