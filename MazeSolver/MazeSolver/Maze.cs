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
        public int size { get; set; }
        public enum MazeType
        {
            Wall = 0,
            Path = 1,
            Junction = 2,
            JunctionConnection = 3,
            Solution = 4,
        }


        public Maze(int[,] maze)
        {
            this.maze = maze;

            mazeGraph = new MazeGraph(maze);

            size = mazeGraph.getJunctions().Count;
        }

        public MazeJunction getStartJunction()
        {
            return mazeGraph.startJunction;
        }

        public MazeJunction getEndJunction()
        {
            return mazeGraph.endJunction;
        }

        public int[,] getMazeArray()
        {
            return maze;
        }

        public void showJunctions()
        {
            foreach (MazeJunction m in mazeGraph.getJunctions())
            {
                maze[m.getXCoordinate(), m.getYCoordinate()] = (int)Maze.MazeType.Junction;
            }
        }

        public void hideJunctions()
        {
            foreach (MazeJunction m in mazeGraph.getJunctions())
            {
                maze[m.getXCoordinate(), m.getYCoordinate()] = (int)Maze.MazeType.Path;
            }
        }

        public void showPaths()
        {
            foreach (MazeJunction m in mazeGraph.getJunctions())
            {
                if(m.north != null)
                {
                    for(int i = (m.getYCoordinate() - 1); i > m.north.getYCoordinate(); i--)
                    {
                        maze[m.getXCoordinate(), i] = (int)Maze.MazeType.JunctionConnection;
                    }
                }

                if (m.south != null)
                {
                    for (int i = (m.getYCoordinate() + 1); i < m.south.getYCoordinate(); i++)
                    {
                        maze[m.getXCoordinate(), i] = (int)Maze.MazeType.JunctionConnection;
                    }
                }

                if (m.east != null)
                {
                    for (int i = (m.getXCoordinate() + 1); i < m.east.getXCoordinate(); i++)
                    {
                        maze[i, m.getYCoordinate()] = (int)Maze.MazeType.JunctionConnection;
                    }
                }

                if (m.west != null)
                {
                    for (int i = (m.getYCoordinate() - 1); i > m.west.getYCoordinate(); i--)
                    {
                        maze[i, m.getYCoordinate()] = (int)Maze.MazeType.JunctionConnection;
                    }
                }
            }
        }

        public void hidePaths()
        {
            for (int i = 1; i < (maze.GetLength(1) - 1); i++)
            {
                for (int j = 1; j < (maze.GetLength(0) - 1); j++)
                {
                    if (maze[j, i] == (int)Maze.MazeType.JunctionConnection)
                    {
                        maze[j, i] = (int)Maze.MazeType.Path;
                    }
                }
            }
        }

        public void hideSolution()
        {
            for (int i = 1; i < (maze.GetLength(1) - 1); i++)
            {
                for (int j = 1; j < (maze.GetLength(0) - 1); j++)
                {
                    if (maze[j, i] == (int)Maze.MazeType.Solution)
                    {
                        maze[j, i] = (int)Maze.MazeType.Path;
                    }
                }
            }

            mazeGraph.ResetJunctions();
        }

        public void connectJunctions(MazeJunction start, MazeJunction end)
        {
            
            if (start.getXCoordinate() == end.getXCoordinate())
            {
                if(start.getYCoordinate() > end.getYCoordinate())
                {
                    for (int i = start.getYCoordinate(); i >= end.getYCoordinate(); i--)
                    {
                        maze[start.getXCoordinate(), i] = (int)Maze.MazeType.Solution;
                    }
                }
                else if (start.getYCoordinate() < end.getYCoordinate())
                {
                    for (int i = start.getYCoordinate(); i <= end.getYCoordinate(); i++)
                    {
                        maze[start.getXCoordinate(), i] = (int)Maze.MazeType.Solution;
                    }
                }
            }
            else if (start.getYCoordinate() == end.getYCoordinate())
            {
                if (start.getXCoordinate() > end.getXCoordinate())
                {
                    for (int i = start.getXCoordinate(); i >= end.getXCoordinate(); i--)
                    {
                        maze[i, start.getYCoordinate()] = (int)Maze.MazeType.Solution;
                    }
                }
                else if (start.getXCoordinate() < end.getXCoordinate())
                {
                    for (int i = start.getXCoordinate(); i <= end.getXCoordinate(); i++)
                    {
                        maze[i, start.getYCoordinate()] = (int)Maze.MazeType.Solution;
                    }
                }
            }
        }

        public void printSolution(List<MazeJunction> solution)
        {
            MazeJunction previous = solution.First();

            foreach (MazeJunction next in solution.Skip(1))
            {
                connectJunctions(previous, next);

                previous = next;
            }
        }
    }
}
