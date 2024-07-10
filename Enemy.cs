using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCells
{
    public class Enemy : Entity
    {
        // Enemy entities, does damage to the player if player has no attack, can be moved by dungeon master
        public Enemy() : base("Enemy", _rng.Next(1, 7), 0, 0, EntityType.Enemy, "enemy.png")
        {
            // Set after, otherwise the numbers will be different if i use _rng to set the coins as well
            Coins = Health;                     // Value to initialise treasure entity when enemy dies
        }

        public override void Draw(int x, int y)
        {
            //SplashKit.FillCircle(Color.Red, x, y, 50);

            Bitmap image = SplashKit.LoadBitmap("enemy", ImagePath);
            DrawingOptions scale = SplashKit.OptionScaleBmp(3.5, 3.5);
            SplashKit.DrawBitmap(image, x - 15, y - 15, scale);
        }
    }
}
