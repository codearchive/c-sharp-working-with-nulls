using System;

namespace module_02
{
    class Program
    {
        static void Main()
        {
            var player = new PlayerCharacter();
            player.Name = "Sarah";
            // player.DaysSinceLastLogin = 42;

            PlayerDisplayer.Write(player);
        }
    }
}
