using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLegends.Domain
{
    class Monster
    {
        public int Hp { get; set; }
        public int Damage { get; set; }
        public int MagicResist { get; set; }
        public int Armor { get; set; }
        public int Speed { get; set; }
        public int Xp { get; set; }
        public int Level { get; set; }
        public double AttackSpeed { get; set; }
        public int Attack()
        {
            return 0;
        }
    }
}
