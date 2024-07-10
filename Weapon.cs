using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCells
{
    public class Weapon : Entity
    {
        // Weapon a player can pickup, replaces player attakc with weapon attack
        public Weapon() : base("Sword", 0, 0, _rng.Next(3, 6), EntityType.Weapon, "sword.png") { }

        public override void Draw(int x, int y)
        {
            //SplashKit.FillCircle(Color.Silver, x, y, 50);

            Bitmap image = SplashKit.LoadBitmap("sword", ImagePath);
            DrawingOptions scale = SplashKit.OptionScaleBmp(3.5, 3.5);
            SplashKit.DrawBitmap(image, x - 14, y - 16, scale);
        }
    }
}
