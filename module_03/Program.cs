using System;

namespace module_03
{
    class Program
    {
        static void Main()
        {
            PlayerCharacter player = new PlayerCharacter();
            player.DaysSinceLastLogin = 42;

            int days = player?.DaysSinceLastLogin ?? -1;


            //int days = player.DaysSinceLastLogin.Value;

            Console.WriteLine(days);
        }
    }
}
