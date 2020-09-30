using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Classes
{
    class Movement
    {
        public Movement()
        {
            
        }

        // Get the starting point
        public void MovePlane(PictureBox plane, FlowLayoutPanel panel)
        {
            string name;
            plane.Visible = true;

            foreach (PictureBox item in panel.Controls)
            {
                if (!(item.Image == null))
                {
                    name = item.Tag.ToString();
                    if (name == "start.png")
                    {
                        plane.Parent = panel;
                        plane.BringToFront();
                        plane.Location = item.Location;
                    }
                }
            }
        }

        public void Move(PictureBox plane, int x, int y)
        {
            int curx;
            int newx = x;
            int cury;
            int newy = y;
            foreach (Point item in DataHandler.shortestPath)
            {
                if (item != null)
                {
                    switch (item.direction)
                    {
                        case 'R':
                            curx = plane.Location.X;
                            newy = plane.Location.Y;
                            newx = curx + 60;
                            break;
                        case 'U':
                            cury = plane.Location.Y;
                            newx = plane.Location.X;
                            newy = cury - 60;
                            break;
                        case 'D':
                            cury = plane.Location.Y;
                            newx = plane.Location.X;
                            newy = cury + 60;
                            break;
                        case 'L':
                            curx = plane.Location.X;
                            newy = plane.Location.Y;
                            newx = curx - 60;
                            break;
                        case 'S':
                            newx = plane.Location.X;
                            newy = plane.Location.Y;
                            break;
                    }
                }
                var updateAction = new Action(() => {plane.Location = new System.Drawing.Point(newx, newy); });
                plane.Invoke(updateAction);
                Thread.Sleep(50);
            }
        }
    }
}
