using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;


namespace DungeonCells
{
    public abstract class Entity
    {
        // Template for an entity
        protected static Random _rng = new Random();
        private int _health;
        private int _coins;
        private int _attack;
        private string _name;
        private EntityType _entityID;
        private string _imagePath;

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Coins
        {
            get { return _coins; }
            set { _coins = value; }
        }

        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        public string Name
        {
            get { return _name; }
        }

        public EntityType EntityType
        {
            get { return _entityID; }
        }

        public string ImagePath
        {
            get { return _imagePath; }
        }

        public Entity(string name, int health, int coins, int attack, EntityType entityID, string imageFile)
        {
            _name = name;
            _health = health;
            _coins = coins;
            _attack = attack;
            _entityID = entityID;
            if (entityID == EntityType.Empty)
            {
                _imagePath = imageFile;
            }
            else
            {
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();
                string solutionDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../.."));
                _imagePath = Path.Combine(solutionDirectory, "Resources", "Images", imageFile);
            }
        }

        public abstract void Draw(int x, int y);
    }
}
