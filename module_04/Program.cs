using System;

namespace module_04
{
    class Program
    {
        static void Main()
        {
            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Sarah"
            };
            PlayerCharacter amrit = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "Amrit"
            };
            PlayerCharacter gentry = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Gentry"
            };

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);

            Console.ReadLine();
        }
    }
}
