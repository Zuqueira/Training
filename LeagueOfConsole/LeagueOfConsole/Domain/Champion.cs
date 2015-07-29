using System;
using System.Collections.Generic;

namespace LeagueOfConsole.Domain
{
    public class Champion
    {
        public String Name { get; set; }
        public String NickName { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public double Magic { get; set; }
        public int Speed { get; set; }
        public int Range { get; set; }
        public int Atk { get; set; }
        public int AtkSpeed { get; set; }
        public int Armor { get; set; }
        public int MagicResist { get; set; }
        public String Skill { get; set; }
        public String Skill1 { get; set; }
        public String Skill2 { get; set; }
        public String Skill3 { get; set; }
        public String Skill4 { get; set; }

        public Champion(String name, String nickName)
        {
            Name = name;
            NickName = nickName;
        }
    }
}
