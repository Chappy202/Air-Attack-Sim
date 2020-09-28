using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Classes
{
    class PathFinding
    {
        public static Queue<Point> queue = new Queue<Point>();

        static int[,] mat = {{ 5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5 },
            { 5,0,0,5,0,0,0,0,0,0,0,0,0,0,0,9,5 },
            { 5,0,0,5,0,0,0,0,0,0,0,0,0,0,0,0,5 },
            { 5,0,0,5,0,0,0,0,0,0,0,0,0,0,0,0,5 },
            { 5,0,0,5,5,5,5,0,0,0,0,0,0,0,0,0,5 },
            { 5,0,0,0,0,0,5,0,0,0,0,0,0,0,0,0,5 },
            { 5,0,0,0,0,0,5,5,5,0,0,0,0,0,0,0,5 },
            { 5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,5 },
            { 5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,5 },
            { 5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5 } };

        public static Point BFS(int x, int y)
        {
            queue.Enqueue(new Point(x, y, null, 0, 'S'));
            while (queue.Count != 0)
            {
                Point p = queue.Dequeue();

                if (mat[p.x, p.y] == 9)
                {
                    Point endP = new Point(p.x + 1, p.y, p, p.dis + 1, 'E');
                    return endP;
                }

                if (isFree(p.x + 1, p.y))
                {
                    mat[p.x, p.y] = -1;
                    Point nextP = new Point(p.x + 1, p.y, p, p.dis + 1, 'D');
                    queue.Enqueue(nextP);
                }

                if (isFree(p.x - 1, p.y))
                {
                    mat[p.x, p.y] = -1;
                    Point nextP = new Point(p.x - 1, p.y, p, p.dis + 1, 'U');
                    queue.Enqueue(nextP);
                }

                if (isFree(p.x, p.y + 1))
                {
                    mat[p.x, p.y] = -1;
                    Point nextP = new Point(p.x, p.y + 1, p, p.dis + 1, 'R');
                    queue.Enqueue(nextP);
                }

                if (isFree(p.x, p.y - 1))
                {
                    mat[p.x, p.y] = -1;
                    Point nextP = new Point(p.x, p.y - 1, p, p.dis + 1, 'L');
                    queue.Enqueue(nextP);
                }
            }
            return null;
        }

        public static bool isFree(int x, int y)
        {
            if ((x >= 0 && x < mat.Length) && (y >= 0 && y < mat.Length) && (mat[x, y] == 0 || mat[x, y] == 9))
            {
                return true;
            }
            else return false;
        }
    }
}
