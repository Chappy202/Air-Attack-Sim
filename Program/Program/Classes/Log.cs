using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Classes
{
    class Log
    {
        private DateTime date;
        private double damage;
        private double success;
        private string target;
        private string start;
        private string end;
        private string obstacle;
        private int avoided;
        private string reason;
        private double fuelbefore;
        private double fuelafter;
        private string invbefore;
        private string invafter;

        public Log(DateTime date, double damage, double success, string target, string start, string end, string obstacle, 
            int avoided, string reason, double fuelbefore, double fuelafter, string invbefore, string invafter)
        {
            this.date = date;
            this.damage = damage;
            this.success = success;
            this.target = target;
            this.start = start;
            this.end = end;
            this.obstacle = obstacle;
            this.avoided = avoided;
            this.reason = reason;
            this.fuelbefore = fuelbefore;
            this.fuelafter = fuelafter;
            this.invbefore = invbefore;
            this.invafter = invafter;
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public double Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public double Success
        {
            get { return success; }
            set { success = value; }
        }
        public string Target
        {
            get { return target; }
            set { target = value; }
        }
        public string Start
        {
            get { return start; }
            set { start = value; }
        }
        public string End
        {
            get { return end; }
            set { end = value; }
        }
        public string Obstacle
        {
            get { return obstacle; }
            set { obstacle = value; }
        }
        public int Avoided
        {
            get { return avoided; }
            set { avoided = value; }
        }
        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }
        public double FuelBefore
        {
            get { return fuelbefore; }
            set { fuelbefore = value; }
        }
        public double FuelAfter
        {
            get { return fuelafter; }
            set { fuelafter = value; }
        }
        public string InvBefore
        {
            get { return invbefore; }
            set { invbefore = value; }
        }
        public string InvAfter
        {
            get { return invafter; }
            set { invafter = value; }
        }
    }
}
