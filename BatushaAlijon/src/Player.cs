using System;

namespace BatushaAlijon.src
{

    public class Player
    {
        private int health = 15;
        private int coins = 200;
        private int score;

        public Player()
        {
            this.score = 0;
        }

       
        public int GetHealth()
        {
            return this.health;
        }


        public void SetHealth(int health)
        {
            this.health = health;
        }

    
        public int GetScore()
        {
            return this.score;
        }

     
        public void SetScore(int score)
        {
            this.score = score;
        }

       
        public int GetCoins()
        {
            return this.coins;
        }

  
        public void SetCoins(int coins)
        {
            this.coins = coins;
        }

       
        public void LoseHealth(int damage)
        {
            this.health -= damage;
        }

       
        public void GainScore(int points)
        {
            this.score += points;
        }

        public void GainCoins(int coins)
        {
            this.coins += coins;
        }
    }
}
