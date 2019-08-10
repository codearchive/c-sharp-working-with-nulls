using System;

namespace module_03
{
    class Program
    {
        static void Main()
        {
            var player = new PlayerCharacter();
            player.Name = "     ";
            // player.DaysSinceLastLogin = 42;

            PlayerDisplayer.Write(player);
        }
    }
}
