using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Classes
{
    class Point
    {
        public int x;
        public int y;
        public int dis;

        public char direction;

        Point parent;

        public Point(int x, int y, Point parent, int dis, char direction)
        {
            this.x = x;
            this.y = y;
            this.parent = parent;
            this.dis = dis;
            this.direction = direction;
        }

        public Point getParent()
        {
            return this.parent;
        }
    }
}
