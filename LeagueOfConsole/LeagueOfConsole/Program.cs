using LeagueOfConsole.Domain;
using System;

namespace LeagueOfConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Champion ryze = new Champion("Ryze","The Magician");
            ryze.Hp = 400;
            ryze.Mp = 340;
            ryze.Atk = 70;
            ryze.Magic = 55;
            ryze.Armor = 60;
            ryze.MagicResist = 30;
            ryze.Range = 400;
            ryze.Speed = 325;
            ryze.AtkSpeed = 1;

            ryze.Skill = string.Format("Disparo Arcano :\n\t Dispara uma onda de raios em seu alvo.Causa 90({0:F0})",(ryze.Magic/100)*10);
            ryze.Skill1 = "Aprisionamento Trovejante :\n\t Aprisionamento Trovejante deixa seu alvo preso em uma cadeia de relâmpagos dolorosos";
            ryze.Skill2 = "Ricochete :\n\t Envia um circulo de energia concentrada que vai de inimigo para inimigo";
            ryze.Skill3 = "Maestria Do Trovao Foderoso :\n\t Ryze vira o pica ... sem mais...";
            ryze.Skill4 = "Passiva fodinha :\n\t Passiva fodinha da a ryze uma porcentagem de sua mana total em dano.";
            

            Console.WriteLine(
                String.Format(
                    " Nome: {0}\n Nickname: {1}\n Hp: {2}\n Mp: {3}\n Atk: {9}\n Magic: {10}\n Armor: {11}\n MagicResist: {12}\n Range: {13}\n Speed: {14}\n AtkSpeed: {15}\n Skill:  \n{4}\n{5}\n{6}\n{7}\n{8}"
                    , ryze.Name, ryze.NickName, ryze.Hp, ryze.Mp, ryze.Skill, ryze.Skill1, ryze.Skill2, ryze.Skill3, ryze.Skill4, ryze.Atk, ryze.Magic, ryze.Armor, ryze.MagicResist, ryze.Range, ryze.Speed, ryze.AtkSpeed));


            Console.ReadLine();
            
        }
    }
}
