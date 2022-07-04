using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    class BitmapLoader
    {
        public String test { get; set; }

        public BitmapLoader()
        {
            test = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Mazes\63x63\Maze_Diagonal_1.bmp";
            //test = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Mazes\21x21\big.bmp";
        }

        public int[,] ImageLoader()
        {
            Bitmap img = null;

            img = new Bitmap(test);

            int[,] result = new int[img.Width, img.Height];

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    if(img.GetPixel(i, j).GetBrightness() < 0.05f)
                    {
                        result[i, j] = 0;
                    }
                    else
                    {
                        result[i, j] = 1;
                    }
                }
            }

            return result;
        }
    }
}
