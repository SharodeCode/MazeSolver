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

        public void connectJunctions(MazeJunction start, MazeJunction end)
        {
            
            if (start.getXCoordinate() == end.getXCoordinate())
            {
                if(start.getYCoordinate() > end.getYCoordinate())
                {
                    for (int i = start.getYCoordinate(); i >= end.getYCoordinate(); i--)
                    {
                        maze[start.getXCoordinate(), i] = 4;
                    }
                }
                else if (start.getYCoordinate() < end.getYCoordinate())
                {
                    for (int i = start.getYCoordinate(); i <= end.getYCoordinate(); i++)
                    {
                        maze[start.getXCoordinate(), i] = 4;
                    }
                }
            }
            else if (start.getYCoordinate() == end.getYCoordinate())
            {
                if (start.getXCoordinate() > end.getXCoordinate())
                {
                    for (int i = start.getXCoordinate(); i >= end.getXCoordinate(); i--)
                    {
                        maze[i, start.getYCoordinate()] = 4;
                    }
                }
                else if (start.getXCoordinate() < end.getXCoordinate())
                {
                    for (int i = start.getXCoordinate(); i <= end.getXCoordinate(); i++)
                    {
                        maze[i, start.getYCoordinate()] = 4;
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
