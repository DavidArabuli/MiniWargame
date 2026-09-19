using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniWargame
{
     class Board
    {
        public List<GameSpot> GameSpots { get; set; } = new List<GameSpot>();
        public void CreateBoard()
        {
            const int Spacing = 100;

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    GameSpot gameSpot = new GameSpot();

                    gameSpot.X = x * Spacing;
                    gameSpot.Y = y * Spacing;

                    GameSpots.Add(gameSpot);
                }
            }
        }
        public void GenerateCities()
        {
            // Implement city generation logic here
        }
    }
}
