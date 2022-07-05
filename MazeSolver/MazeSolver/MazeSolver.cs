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
        int imageWidth = 500;
        int imageHeight = 500;

        TimeSpan loadImageTime;
        TimeSpan solveMazeTime;

        List<Panel> subMenuPanels = new List<Panel>();

        bool visibleJunctions = false;
        bool visiblePathways = false;
        bool visibleSolution = false;

        bool visibleMaze = false;

        public enum VisualisationType
        {
            Junctions = 0,
            Pathways = 1,
            Solution = 2,
        }

        public MazeSolver()
        {
            InitializeComponent();

            subMenuPanels.Add(panelFileSubmenu);
            subMenuPanels.Add(panelSolveSubmenu);
            subMenuPanels.Add(panelOtherSubmenu);

            InitialiseDesign();
        }

        private void InitialiseDesign()
        {
            foreach(Panel panel in subMenuPanels)
            {
                panel.Visible = false;
            }

            panelMazeSoler.Visible = false;
            panelTitle.Visible = true;
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

        private void HideOtherVisualisations(VisualisationType type)
        {
            if (visibleJunctions && type != VisualisationType.Junctions)
            {
                showJunctions_Click(btnShowJunctions, EventArgs.Empty);
            }

            if (visiblePathways && type != VisualisationType.Pathways)
            {
                btnShowPaths_Click(btnShowPaths, EventArgs.Empty);
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

            pictureBoxMaze.Image = image;
            pictureBoxMaze.Refresh();
        }

        private void showJunctions_Click(object sender, EventArgs e)
        {
            if (!visibleMaze)
                return;

            HideOtherVisualisations(VisualisationType.Junctions);

            Button clickedButton = (Button)sender;

            if (!visibleJunctions)
            {
                maze.showJunctions();
                RefreshBitmap();

                clickedButton.Text = "Hide Junctions";

                visibleJunctions = true;
            }
            else if (visibleJunctions)
            {
                maze.hideJunctions();
                RefreshBitmap();

                clickedButton.Text = "Show Junctions";

                visibleJunctions = false;
            }

        }

        private void btnShowPaths_Click(object sender, EventArgs e)
        {
            if (!visibleMaze)
                return;

            HideOtherVisualisations(VisualisationType.Pathways);

            Button clickedButton = (Button)sender;

            if (!visiblePathways)
            {
                maze.showPaths();
                RefreshBitmap();

                clickedButton.Text = "Hide Pathways";

                visiblePathways = true;
            }
            else if (visiblePathways)
            {
                maze.hidePaths();
                RefreshBitmap();

                clickedButton.Text = "Show Pathways";

                visiblePathways = false;
            }
        }

        private void load_Click(object sender, EventArgs e)
        {

            panelMazeSoler.Visible = true;
            panelTitle.Visible = false;

            // Start Timer
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            
            BitmapLoader bl = new BitmapLoader();

            int[,] test = bl.ImageLoader();

            image = new Bitmap(bl.directory);

            image = ResizeBitmap(image, imageWidth, imageHeight);

            pictureBoxMaze.Width = image.Width;
            panelMazeImage.Width = image.Width;
            pictureBoxMaze.Height = image.Height;
            panelMazeImage.Height = image.Height;
            pictureBoxMaze.Image = image;
            this.Width = image.Width + 1000;
            this.Height = image.Height + 250;
            maze = new Maze(test);

            // Stop timer and print results
            watch.Stop();
            loadImageTime = watch.Elapsed;
            labelMazeLoadTime.Text = "Maze Load Time: " + loadImageTime.Minutes.ToString() + ":" + loadImageTime.Seconds.ToString() + ":" + loadImageTime.Milliseconds.ToString();

            visibleMaze = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            image.Save("myfile.bmp");
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            if (!visibleMaze)
                return;

            HideOtherVisualisations(VisualisationType.Solution);

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

            visibleSolution = true;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelFileSubmenu);
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSolveSubmenu);
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelOtherSubmenu);
        }

    }
}
