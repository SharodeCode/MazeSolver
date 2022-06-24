using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeSolver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            Bitmap image = new Bitmap(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Mazes\63x63\Maze_Diagonal_1.bmp");

            image = ResizeBitmap(image, 441, 441);

            pictureBox1.Image = image;
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
    }
}
