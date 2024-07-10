using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCells
{
    public class Potion : Entity
    {
        // Entity which gives a player health
        public Potion() : base("Potion", _rng.Next(1, 4), 0, 0, EntityType.Potion, "health_potion.png") { }

        public override void Draw(int x, int y)
        {
            //SplashKit.FillCircle(Color.Red, x, y, 50);

            Bitmap image = SplashKit.LoadBitmap("potion", ImagePath);
            DrawingOptions scale = SplashKit.OptionScaleBmp(3.5, 3.5);
            SplashKit.DrawBitmap(image, x - 15, y - 16, scale);
        }
    }
}
