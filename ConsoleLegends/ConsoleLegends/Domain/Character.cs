public class Character
{

    public int Hp { get; set; }
    public int Mana { get; set; }
    public int AttackDamage { get; set; }
    public int AbilityPower { get; set; }
    public int Xp { get; set; }
    public int Level { get; set; }
    private Progression _progress;

    public Character(int hp, int mana, int attackdamage, int abilitypower, int xp, int level, Progression progress)
    {
        Hp = hp;
        Mana = mana;
        AttackDamage = attackdamage;
        Xp = xp;
        Level = level;
        _progress = progress;
    }

    //metodo de atacar
    public void LevelUp()
    {
        Hp += _progress.Hp;
        Mana += _progress.Mana;
        AttackDamage += _progress.AttackDamage;
        AbilityPower += _progress.AbilityPower;
        Level += _progress.Level;
        //fora as outras propriedades que aumenta de nivel junto do personagem
    }

    //métodos privados
}