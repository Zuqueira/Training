using System;

public class Progression {
    
    public int Hp {get; set;}
    public int Mana {get; set;}
    public int AttackDamage {get; set;}
    public int AbilityPower {get; set;}
    public int Level {get; set;}
    
    public Progression(int hp,int mana,int attackDamage,int abilityPower,int level){
        Hp = hp;
        Mana = mana;
        AttackDamage = attackDamage;
        AbilityPower = abilityPower;
        Level = level;
        
    }
}