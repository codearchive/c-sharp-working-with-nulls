using System;
using System.Collections.Generic;
using System.Text;

namespace module_03
{
    class PlayerCharacter
    {
        public PlayerCharacter()
        {
            DateOfBirth = null;
            DaysSinceLastLogin = null;
        }

        public string Name { get; set; }

        public int? DaysSinceLastLogin { get; set; } // Nullable<int> = int?

        public DateTime? DateOfBirth { get; set; } // Nullable<DateTime> = DateTime?

        public bool? IsNoob { get; set; } // default value is "null"
    }
}
