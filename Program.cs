using SimpleTurnBasedGame;
using System;

Hero player = new Hero(110, 29, 12, "Player");
Hero adversary = new Hero(75, 8, 4, "Enemy Goblin");
Random random = new Random();


while (!player.Defeated && !adversary.Defeated) { 
Console.WriteLine(player.HeroName + " HP = " + player.Health + ". " + adversary.HeroName + "HP = " + adversary.Health);
Console.WriteLine("Take an action");

string action = Console.ReadLine();

if (action == "a")
{

    player.Battle(adversary);
}
else
    player.Heal();

if (player.Defeated || adversary.Defeated)
    {
        break;
    }

Console.WriteLine(player.HeroName + " HP = " + player.Health + ". " + adversary.HeroName + "HP = " + adversary.Health);

Console.WriteLine("Enemy turn!");

int rand = random.Next(0, 2);

if (rand == 0)
{
   adversary.Battle(player);
} else
    adversary.Heal();
}