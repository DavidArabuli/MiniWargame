using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniWargame
{
     class Player
    {
        public int strength { get; set; }
        public int gold { get; set; }

        public Player(int strength, int gold)
        {
            this.strength = strength;
            this.gold = gold;
        }
        public void Attack(City city)
        {
            // Implement attack logic here
            if (city.ownedByPlayer == false)
            {
                // Implement logic for attacking an enemy city
                Combat combat = new Combat();
                combat.ResolveCombat(this, city);
            }
        }
        public void Move()
        {
            // Implement move logic here
        }
        public void HireArmy()
        {
            // Implement hire army logic here
        }
    }
}
