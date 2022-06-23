﻿using System;
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
        public int[,] ImageLoader()
        {
            Bitmap img = null;

            String test = Environment.CurrentDirectory + @"\Mazes\63x63\Maze_Diagonal_1.bmp";

            img = new Bitmap(test, true);

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