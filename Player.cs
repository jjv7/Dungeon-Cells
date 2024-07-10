using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCells
{
    public class Player : Entity
    {
        // Entity controlled by the player
        private int _kills;

        public int Kills
        {
            get { return _kills; }
            set { _kills = value; }
        }

        public Player() : base("Player", 10, 0, 5, EntityType.Player, "player.png")
        {
            _kills = 0;                     // keep track of enemy kills for score
        }

        public override void Draw(int x, int y)
        {
            //SplashKit.FillCircle(Color.Green, x, y, 50);

            Bitmap image = SplashKit.LoadBitmap("player", ImagePath);
            DrawingOptions scale = SplashKit.OptionScaleBmp(3.5, 3.5);
            SplashKit.DrawBitmap(image, x - 15, y - 15, scale);
        }
    }
}
