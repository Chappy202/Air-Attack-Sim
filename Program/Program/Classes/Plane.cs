using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Classes
{
    class Plane
    {
        private string name;
        private double speed;
        private double currspeed;
        private double tanksize;
        private double fuel;
        private int invcapacity;
        private string weapons;

        public Plane()
        {
            
        }

        public Plane(string name, double speed, double currspeed, double tanksize, double fuel, int invcapacity, string weapons)
        {
            this.name = name;
            this.speed = speed;
            this.currspeed = currspeed;
            this.tanksize = tanksize;
            this.fuel = fuel;
            this.invcapacity = invcapacity;
            this.weapons = weapons;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public double CurrSpeed
        {
            get
            {
                return currspeed;
            }
            set
            {
                currspeed = value;
            }
        }

        public double TankSize
        {
            get
            {
                return tanksize;
            }
            set
            {
                tanksize = value;
            }
        }

        public double Fuel
        {
            get
            {
                return fuel;
            }
            set
            {
                fuel = value;
            }
        }

        public int InvCapacity
        {
            get
            {
                return invcapacity;
            }
            set
            {
                invcapacity = value;
            }
        }

        public string Weapons
        {
            get
            {
                return weapons;
            }
            set
            {
                weapons = value;
            }
        }
    }
}
