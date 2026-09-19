using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniWargame
{
     class Combat
    {
        
        public void ResolveCombat(Player player, City city)
        {
            if (player.strength > city.strength)
            {
                // Player wins
                player.gold += 100; // Reward for winning
                Console.WriteLine($"Player wins! Gained 100 gold. Total gold: {player.gold}");
                city.ownedByPlayer = true; // Player now owns the city
            }
            else
            {
                // City wins
                player.strength -= 10; // Penalty for losing
                Console.WriteLine($"City wins! Player loses 10 strength. Remaining strength: {player.strength}");
            }
        }
    }
}
