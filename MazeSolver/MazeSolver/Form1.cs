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
    public partial class Form1 : Form
    {
        private Maze maze;

        public Form1()
        {
            InitializeComponent();

            BitmapLoader bl = new BitmapLoader();

            int[,] test = bl.ImageLoader();

            maze = new Maze(test);
        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {


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

            int width = mazeArray.GetLength(1);
            int height = mazeArray.GetLength(0);

            Bitmap bmp = new Bitmap(width, height);

            for (int i = 0; i < mazeArray.GetLength(0); i++)
            {
                for (int j = 0; j < mazeArray.GetLength(1); j++)
                {
                    if(mazeArray[i, j] == 0)
                    {
                        bmp.SetPixel(i, j, Color.Black);
                    }
                    else if (mazeArray[i, j] == 1)
                    {
                        bmp.SetPixel(i, j, Color.White);
                    }
                    else if (mazeArray[i, j] == 2)
                    {
                        bmp.SetPixel(i, j, Color.Red);
                    }

                }
            }

            bmp = ResizeBitmap(bmp, 441, 441);

            
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
            bmp.Save("myfile.bmp");
        }

        private void load_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Mazes\63x63\Maze_Diagonal_1.bmp");

            image = ResizeBitmap(image, 441, 441);

            pictureBox1.Image = image;
        }
    }
}
