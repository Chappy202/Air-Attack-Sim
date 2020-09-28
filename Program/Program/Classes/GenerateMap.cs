using System;
using System.Collections.Generic;
using System.Linq;
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
            string image, name;
            int col = 0;
            int[] arr = new int[170];

            foreach (PictureBox item in panel.Controls)
            {
                arr[col] = 0;
                if (!(item.Image == null))
                {
                    image = item.ImageLocation;
                    name = image.Substring(image.LastIndexOf('\\') + 1);

                    switch (name)
                    {
                        
                    }
                }
            }
         }
    }
}
