using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeSolver
{
    public partial class MazeSolver : Form
    {
        private Maze maze;

        Bitmap image;

        public MazeSolver()
        {
            InitializeComponent();
        }

        private Bitmap ResizeBitmap(Bitmap image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                g.DrawImage(image, 0, 0, width, height);
            }

            return result;
        }

        private void showJunctions_Click(object sender, EventArgs e)
        {
            int[,] mazeArray = maze.getMazeArray();

            maze.visualiseJunctions();
            maze.visualisePaths();

            int width = mazeArray.GetLength(1);
            int height = mazeArray.GetLength(0);

            image = new Bitmap(width, height);

            for (int i = 0; i < mazeArray.GetLength(0); i++)
            {
                for (int j = 0; j < mazeArray.GetLength(1); j++)
                {
                    if(mazeArray[i, j] == 0)
                    {
                        image.SetPixel(i, j, Color.Black);
                    }
                    else if (mazeArray[i, j] == 1)
                    {
                        image.SetPixel(i, j, Color.White);
                    }
                    else if (mazeArray[i, j] == 2)
                    {
                        image.SetPixel(i, j, Color.Red);
                    }
                    else if (mazeArray[i, j] == 3)
                    {
                        image.SetPixel(i, j, Color.Green);
                    }
                }
            }

            image = ResizeBitmap(image, 441, 441);

            
            pictureBox1.Image = image;
            pictureBox1.Refresh();
        }

        private void load_Click(object sender, EventArgs e)
        {
            BitmapLoader bl = new BitmapLoader();

            int[,] test = bl.ImageLoader();

            maze = new Maze(test);

            image = new Bitmap(bl.test);

            image = ResizeBitmap(image, 441, 441);

            pictureBox1.Image = image;
        }

        private void save_Click(object sender, EventArgs e)
        {
            image.Save("myfile.bmp");
        }
    }
}
