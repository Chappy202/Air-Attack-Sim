using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Classes
{
    class GenerateMap
    {
        private int[,] map;

        public int[,] _Map
        {
            get
            {
                return map;
            }
            set
            {
                map = value;
            }
        }
        public GenerateMap() { }

        public void CreateMap(FlowLayoutPanel panel)
        {
            string image;
            int col = 0;
            int[] arr = new int[170];

            foreach (PictureBox item in panel.Controls)
            {
                arr[col] = 0;
                if (item.Tag != null)
                {
                    image = item.Tag.ToString();

                    switch (image)
                    {
                        case "AA.png":
                            arr[col] = 5;
                            break;
                        case "artilary.png":
                            arr[col] = 5;
                            break;
                        case "building.png":
                            arr[col] = 5;
                            break;
                        case "cafeteria.png":
                            arr[col] = 5;
                            break;
                        case "finish.png":
                            arr[col] = 9;
                            break;
                        case "hangar.png":
                            arr[col] = 5;
                            break;
                        case "HQ.png":
                            arr[col] = 5;
                            break;
                        case "Med.png":
                            arr[col] = 5;
                            break;
                        case "plane.png":
                            arr[col] = 5;
                            break;
                        case "radar.png":
                            arr[col] = 5;
                            break;
                        case "start.png":
                            arr[col] = 1;
                            break;
                        case "tent.png":
                            arr[col] = 5;
                            break;
                        default:
                            arr[col] = 5;
                            break;
                    }
                }

                col++;
            }

            if (checkInput(arr))
            {
                var TwoD = ConvertTo2D(arr, 10, 17);
                object p = new FileHandler().printMap(2D);
                PathFinding path = new PathFinding();
                path.Start(TwoD);
            }
            else
            {
                MessageBox.Show("Make sure to add a start and end!");
            }
         }

        public bool checkInput(int[] input)
        {
            bool val = false;
            if (input.Contains(1) && input.Contains(9))
            {
                val = true;
            }
            else
            {
                val = false;
            }

            return val;
        }

        private static T[,] ConvertTo2D<T>(T[] input, int height, int width)
        {
            T[,] output = new T[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    output[i, j] = input[i * width + j];
                }
            }

            return output;
        }
    }
}
