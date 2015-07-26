using System;

namespace ConsoleLegends
{
    class Program
    {
        static void Main()
        {
            Progression progress = new Progression(20, 10, 5, 0, 1);
            Character riven = new Character(500, 350, 80, 0, 1,0, progress);

            Console.WriteLine(riven.Hp);
            Console.WriteLine(riven.Mana);
            Console.WriteLine(riven.AttackDamage);
            Console.WriteLine(riven.AbilityPower);
            Console.WriteLine(riven.Level);

            riven.LevelUp();
            riven.LevelUp();

            Console.WriteLine(riven.Hp);
            Console.WriteLine(riven.Mana);
            Console.WriteLine(riven.AttackDamage);
            Console.WriteLine(riven.AbilityPower);
            Console.WriteLine(riven.Level);
        }
    }
}
