using ConsoleLegends.Domain.Base_Class;

public class Character
{

    public int Hp { get; set; }
    public int Mana { get; set; }
    public int AttackDamage { get; set; }
    public int AbilityPower { get; set; }
    public int Xp { get; set; }
    public int Level { get; set; }
    private Progression _progress;

    public Character(int hp, int mana, int attackdamage, int abilitypower, Progression progress)
    {
        Hp = hp;
        Mana = mana;
        AttackDamage = attackdamage;
        Xp = 0;
        Level = 1;
        _progress = progress;
    }

    public int Attack()
    {
        return 0;
    }

    //metodo de atacar
    private void LevelUp()
    {
        Level++;
        Hp += _progress.Hp;
        Mana += _progress.Mana;
        AttackDamage += _progress.AttackDamage;
        AbilityPower += _progress.AbilityPower;
        //fora as outras propriedades que aumenta de nivel junto do personagem
    }

    //métodos privados
}