using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeSolver
{
    class BitmapLoader
    {
        public String directory { get; set; }

        public BitmapLoader()
        {


        }

        public void setDirectory(MazeSolver.FileToLoad fileToLoad)
        {
            switch (fileToLoad)
            {
                case MazeSolver.FileToLoad.Default:
                    OpenFileDialog fdlg = new OpenFileDialog();

                    if (fdlg.ShowDialog() == DialogResult.OK)
                    {
                        directory = fdlg.FileName;
                    }

                    break;
                case MazeSolver.FileToLoad.Small:
                    directory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Mazes\test\150x150.bmp";
                    break;
                case MazeSolver.FileToLoad.Medium:
                    directory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Mazes\test\200x200.bmp";
                    break;
                case MazeSolver.FileToLoad.Large:
                    directory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Mazes\test\250x250.bmp";
                    break;
                default:
                    break;
            }
            
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
