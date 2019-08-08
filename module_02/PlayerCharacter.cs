using System;
using System.Collections.Generic;
using System.Text;

namespace module_02
{
    class PlayerCharacter
    {
        public PlayerCharacter()
        {
            DateOfBirth = null;
            DaysSinceLastLogin = null;
        }

        public string Name { get; set; }

        public Nullable<int> DaysSinceLastLogin { get; set; }

        public Nullable<DateTime> DateOfBirth { get; set; }
    }
}
