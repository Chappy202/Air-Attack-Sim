using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Classes
{
    class Coords
    {
        public int x, y, range;
        public char direction;

        Coords parent;

        public Coords(int x, int y, Coords parent, int range, char direction)
        {
            this.x = x;
            this.y = y;
            this.parent = parent;
            this.range = range;
            this.direction = direction;
        }

        public Coords getParent()
        {
            return this.parent;
        }
    }
}
