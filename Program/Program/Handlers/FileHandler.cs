using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Classes
{
    class FileHandler
    {
        public FileHandler()
        {
            // Initialization code goes here
        }

        public static void printMap(int[,] arr)
        {
            using (var sw = new StreamWriter("map.txt"))
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        sw.Write(arr[i,j]);
                    }
                    sw.Write("\n");
                }
                sw.Flush();
                sw.Close();
            }
        }
    }
}
