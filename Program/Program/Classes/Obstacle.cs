using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Classes
{
    class Obstacle
    {
        private string name;
        private bool doesDamage;
        private int priority;
        private double health;
        private int height;
        private int range;
        private int x;
        private int y;

        public Obstacle()
        {
            
        }

        public Obstacle(string name, int x, int y)
        {
            this.y = y;
            this.x = x;
            this.name = name;
        }

        public Obstacle(string name, bool damage, int priority, double health, int height, int range, int x, int y)
        {
            this.name = name;
            this.doesDamage = damage;
            this.priority = priority;
            this.health = health;
            this.height = height;
            this.range = range;
            this.x = x;
            this.y = y;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool DoesDamage
        {
            get { return doesDamage; }
            set { doesDamage = value; }
        }
        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public double Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Range
        {
            get { return range; }
            set { range = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
