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
        public String directory { get; set; }

        public BitmapLoader()
        {
            //directory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Mazes\63x63\Maze_Diagonal_1.bmp";
            //directory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Mazes\21x21\big.bmp";

            directory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Mazes\63x63\Maze_Prims_1.bmp";
        }

        public int[,] ImageLoader()
        {
            Bitmap img = null;

            img = new Bitmap(directory);

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
