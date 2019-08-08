using System;
using System.Collections.Generic;
using System.Text;

namespace module_02
{
    class PlayerCharacter
    {
        public PlayerCharacter()
        {
            DateOfBirth = DateTime.MinValue; // Magic number
            DaysSinceLastLogin = -1; // Magic number
        }

        public string Name { get; set; }

        public int DaysSinceLastLogin { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
