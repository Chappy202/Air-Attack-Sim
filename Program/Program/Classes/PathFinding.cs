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
        public PathFinding()
        {
            
        }

        private static int[,] map;

        public static Queue<Point> queue = new Queue<Point>();

        public static Point BFS(int x, int y)
        {
            queue.Enqueue(new Point(x, y, null, 0, 'S'));
            while (queue.Count != 0)
            {
                Point point = queue.Dequeue();
                if (map[point.x, point.y]==9)
                {
                    Point endP = new Point(point.x + 1, point.y, point, point.dis + 1, 'E');
                    return endP;
                }

                if (isOpen(point.x +1, point.y))
                {
                    map[point.x, point.y] = -1;
                    Point nextP = new Point(point.x + 1, point.y, point, point.dis + 1, 'D');
                    queue.Enqueue(nextP);

                }
                if (isOpen(point.x - 1, point.y))
                {
                    map[point.x, point.y] = -1;
                    Point nextP = new Point(point.x - 1, point.y, point, point.dis + 1, 'U');
                    queue.Enqueue(nextP);

                }

                if (isOpen(point.x, point.y + 1))
                {
                    map[point.x, point.y] = -1;
                    Point nextP = new Point(point.x, point.y + 1, point, point.dis + 1, 'R');
                    queue.Enqueue(nextP);

                }

                if (isOpen(point.x, point.y - 1))
                {
                    map[point.x, point.y] = -1;
                    Point nextP = new Point(point.x, point.y - 1, point, point.dis + 1, 'L');
                    queue.Enqueue(nextP);

                }
            }

            return null;
        }

        public static bool isOpen(int x, int y)
        {
            if ((x >= 0 && x < map.Length) && (y >= 0 && y < map.Length) && (map[x, y] == 0 || map[x, y] == 9))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Start(int[,] Map)
        {
            map = Map;

            Tuple<int, int> start = GetStart();

            Point p = BFS(start.Item1, start.Item2);
            List<Point> path = new List<Point>();

            path.Add(p.getParent());

            for (int i = 0; i < p.dis; i++)
            {
                path.Add(path[i].getParent());
            }

            path.Reverse();

            string pathString = null;
            foreach (var item in path)
            {
                if (item != null)
                {
                    pathString += $"{item.direction}";
                }
            }

            DataHandler.shortestPath = path;
        }

        public Tuple<int, int> GetStart()
        {
            Tuple<int, int> start = null;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (map[i, j] == 1)
                    {
                        start = new Tuple<int, int>(i, j);
                    }
                }
            }

            return start;
        }
    }
}
