using System;
namespace ConsoleFun
{
    public class Player
    {
        private string name;
        private int health;

        public Player(string name)
        {
            this.name = name;
            this.health = 100;
        }

        public string getName()
        {
            return this.name;
        }

        public int getHealth()
        {
            return this.health;
        }

        public int takeDamage(int damage)
        {
            this.health -= damage;
            return this.health;
        }
    }
}
