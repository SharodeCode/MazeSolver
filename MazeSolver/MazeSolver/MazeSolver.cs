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
        int imageWidth = 1000;
        int imageHeight = 1000;

        TimeSpan loadImageTime;
        TimeSpan solveMazeTime;

        List<Panel> subMenuPanels = new List<Panel>();

        public MazeSolver()
        {
            InitializeComponent();

            subMenuPanels.Add(panelFileSubmenu);
            subMenuPanels.Add(panelSolveSubmenu);

            InitialiseDesign();
        }

        private void InitialiseDesign()
        {
            foreach(Panel panel in subMenuPanels)
            {
                panel.Visible = false;
            }
        }

        private void HideSubmenu()
        {
            foreach (Panel panel in subMenuPanels)
            {
                if (panel.Visible == true)
                    panel.Visible = false;

            }

        }

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
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

        private void RefreshBitmap()
        {
            int[,] mazeArray = maze.getMazeArray();

            int width = mazeArray.GetLength(1);
            int height = mazeArray.GetLength(0);

            image = new Bitmap(width, height);

            for (int i = 0; i < mazeArray.GetLength(0); i++)
            {
                for (int j = 0; j < mazeArray.GetLength(1); j++)
                {
                    if (mazeArray[i, j] == (int)Maze.MazeType.Wall)
                    {
                        image.SetPixel(i, j, Color.Black);
                    }
                    else if (mazeArray[i, j] == (int)Maze.MazeType.Path)
                    {
                        image.SetPixel(i, j, Color.White);
                    }
                    else if (mazeArray[i, j] == (int)Maze.MazeType.Junction)
                    {
                        image.SetPixel(i, j, Color.Red);
                    }
                    else if (mazeArray[i, j] == (int)Maze.MazeType.JunctionConnection)
                    {
                        image.SetPixel(i, j, Color.Green);
                    }
                    else if (mazeArray[i, j] == (int)Maze.MazeType.Solution)
                    {
                        image.SetPixel(i, j, Color.Yellow);
                    }
                }
            }

            image = ResizeBitmap(image, imageWidth, imageHeight);

            pictureBox1.Image = image;
            pictureBox1.Refresh();
        }

        private void showJunctions_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.Text.Equals("Show Junctions"))
            {
                maze.showJunctions();
                RefreshBitmap();

                clickedButton.Text = "Hide Junctions";
            }
            else if (clickedButton.Text.Equals("Hide Junctions"))
            {
                maze.hideJunctions();
                RefreshBitmap();

                clickedButton.Text = "Show Junctions";
            }

        }

        private void load_Click(object sender, EventArgs e)
        {
            // Start Timer
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            
            BitmapLoader bl = new BitmapLoader();

            int[,] test = bl.ImageLoader();

            image = new Bitmap(bl.directory);

            image = ResizeBitmap(image, imageWidth, imageHeight);

            pictureBox1.Image = image;

            maze = new Maze(test);

            // Stop timer and print results
            watch.Stop();
            loadImageTime = watch.Elapsed;
            labelMazeLoadTime.Text = "Maze Load Time: " + loadImageTime.Minutes.ToString() + ":" + loadImageTime.Seconds.ToString() + ":" + loadImageTime.Milliseconds.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            image.Save("myfile.bmp");
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            // Start Timer
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();

            SolvingAlgorithm solver = new SolvingAlgorithm();

            List<MazeJunction> solution = solver.BreadthFirst(maze);

            // Stop timer and print results
            watch.Stop();
            solveMazeTime = watch.Elapsed;
            labelMazeSolveTime.Text = "Maze Solve Time: " + solveMazeTime.Minutes.ToString() + ":" + solveMazeTime.Seconds.ToString() + ":" + solveMazeTime.Milliseconds.ToString();

            maze.printSolution(solution);

            RefreshBitmap();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelFileSubmenu);
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSolveSubmenu);
        }

    }
}
