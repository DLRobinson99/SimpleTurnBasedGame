using System.Runtime.CompilerServices;

namespace SimpleTurnBasedGame
{
    internal class Hero
    {
        private int maxHealth;
        private int currentHealth;
        private int attackRating;
        private int healingRating;
        private string heroName;
        private Random randomValue;

        public int Health { get {return currentHealth;} }

        public string HeroName { get { return heroName; } }

        public bool Defeated { get { return currentHealth <= 0; } }




        public Hero(int maxHealth, int attackRating, int healingRating, string heroName)
        {
            this.maxHealth = maxHealth;
            this.currentHealth = maxHealth;
            this.attackRating = attackRating;
            this.healingRating = healingRating;
            this.heroName = heroName;
            this.randomValue = new Random();
        }

        public void Battle(Hero heroToAttack)

        {

            double rng = randomValue.NextDouble();

            rng = rng / 2 + 0.5f;

            int damageDealt = (int)(attackRating * rng);

            heroToAttack.damageReceived(damageDealt);

            Console.WriteLine(heroName + " targeted " + heroToAttack.heroName + " and dealt " + damageDealt + " damage ");


        }



        public void damageReceived(int damageDealt)
        {

            currentHealth -= damageDealt;

            if (Defeated)
            {
                Console.WriteLine(HeroName + " has been defeated.");
            }

        }

        public void Heal()

        {

            double rng = randomValue.NextDouble();

            rng = rng / 2 + 0.25f;

            int heal = (int)(healingRating * rng);

            currentHealth = heal + currentHealth > maxHealth ? maxHealth : currentHealth + heal;

            Console.WriteLine(HeroName + " heals " + heal);


        }
    }


}
