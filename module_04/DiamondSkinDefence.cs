using System;
using System.Collections.Generic;
using System.Text;

namespace module_04
{
    class DiamondSkinDefence : SpecialDefence
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 1;
        }
    }
}
