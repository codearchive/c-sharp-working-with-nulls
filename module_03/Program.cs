using System;

namespace module_03
{
    class Program
    {
        static void Main()
        {
            //PlayerCharacter player = new PlayerCharacter();
            //player.DaysSinceLastLogin = 42;

            //int days = player?.DaysSinceLastLogin ?? -1;

            //Console.WriteLine(days);

            PlayerCharacter[] players = new PlayerCharacter[3]
            {
                new PlayerCharacter {Name = "Sarah"},
                new PlayerCharacter(),
                null
            };

            //PlayerCharacter[] players = null;

            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;
        }
    }
}
