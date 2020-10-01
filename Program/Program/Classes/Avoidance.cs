using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Classes
{
    class Avoidance
    {
        private List<Obstacle> obstacles = new List<Obstacle>();
        public Avoidance()
        {
            DataHandler data = new DataHandler();
            // Assign all objects to the object list
            obstacles = data.GetObstacle();
        }

        // Check and see if the current location of the plane, is close to each object registered in the db
        public bool isNear(Point plane)
        {
            foreach (var item in obstacles)
            {
                if ((plane.X < item.X + 20 && plane.X > item.X - 20) && (plane.Y < item.Y + 20 && plane.Y > item.Y - 20))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }
    }
}
