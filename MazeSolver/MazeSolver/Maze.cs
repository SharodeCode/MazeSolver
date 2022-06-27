using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    class Maze
    {
        int[,] maze = null;
        MazeGraph mazeGraph = null;

        public Maze(int[,] maze)
        {
            this.maze = maze;

            mazeGraph = new MazeGraph(maze);

        }

        public int[,] getMazeArray()
        {
            return maze;
        }

        public void visualiseJunctions()
        {
            foreach (MazeJunction m in mazeGraph.getJunctions())
            {
                maze[m.getXCoordinate(), m.getYCoordinate()] = 2;
            }
        }

        public void visualisePaths()
        {
            foreach (MazeJunction m in mazeGraph.getJunctions())
            {
                if(m.north != null)
                {
                    for(int i = (m.getYCoordinate() - 1); i > m.north.getYCoordinate(); i--)
                    {
                        maze[m.getXCoordinate(), i] = 3;
                    }
                }

                if (m.south != null)
                {
                    for (int i = (m.getYCoordinate() + 1); i < m.south.getYCoordinate(); i++)
                    {
                        maze[m.getXCoordinate(), i] = 3;
                    }
                }

                if (m.east != null)
                {
                    for (int i = (m.getXCoordinate() + 1); i < m.east.getXCoordinate(); i++)
                    {
                        maze[i, m.getYCoordinate()] = 3;
                    }
                }

                if (m.west != null)
                {
                    for (int i = (m.getYCoordinate() - 1); i > m.west.getYCoordinate(); i--)
                    {
                        maze[i, m.getYCoordinate()] = 3;
                    }
                }
            }
        }
    }
}
