namespace ConsoleLegends.Domain.Base_Class
{
    public class Progression
    {
        public int Hp { get; set; }
        public int Mana { get; set; }
        public int AttackDamage { get; set; }
        public int AbilityPower { get; set; }

        public Progression(int hp, int mana, int attackDamage, int abilityPower)
        {
            Hp = hp;
            Mana = mana;
            AttackDamage = attackDamage;
            AbilityPower = abilityPower;
        }
    }
}
