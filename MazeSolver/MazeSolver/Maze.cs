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
        List<MazeJunction> junctions = new List<MazeJunction>();

        // Used to detect when a pathways is needed
        bool eastClear;

        MazeJunction westNode = null;

        public Maze(int[,] maze)
        {
            this.maze = maze;
            initialise();
        }

        public void initialise()
        {
            for (int i = 1; i < (maze.GetLength(1) - 1); i++)
            {
                for (int j = 1; j < (maze.GetLength(0) - 1); j++)
                {
                    if(maze[j, i] == 1)
                    {
                        if(checkJunction(j, i))
                        {
                            MazeJunction newJunction = new MazeJunction(j, i);

                            connectNorth(newJunction);
                            connectWest(newJunction);

                            junctions.Add(newJunction);

                            westNode = newJunction;
                            eastClear = true;
                        }
                    }
                    else
                    {
                        eastClear = false;
                        westNode = null;
                    }

                }
            }  
        }

        bool checkJunction(int x, int y)
        {
            bool result = false;

            int north = maze[x, (y + 1)], 
                south = maze[x, (y - 1)], 
                east = maze[(x - 1), y], 
                west = maze[(x + 1), y];



            if (north != south || east != west || ((north == 1) && (south == 1) && (east == 1) && (west == 1)))
            {
                result = true;
            }

            

            return result;
        }

        private void connectNorth(MazeJunction newJunction)
        {

        }

        private void connectWest(MazeJunction newJunction)
        {
            if(eastClear == true)
            {
                newJunction.addPath(MazeJunction.DirectionType.west, westNode);
                westNode.addPath(MazeJunction.DirectionType.east, newJunction);
            }
        }

        public int[,] getMazeArray()
        {
            return maze;
        }

        public List<MazeJunction> getMazeJunctions()
        {
            return junctions;
        }

        public void visualiseJunctions()
        {
            foreach (MazeJunction m in junctions)
            {
                maze[m.getXCoordinate(), m.getYCoordinate()] = 2;
            }
        }

        public void visualisePaths()
        {
            foreach (MazeJunction m in junctions)
            {
                if(m.north != null)
                {
                    for(int i = (m.getYCoordinate() + 1); i < m.north.getYCoordinate(); i++)
                    {
                        maze[m.getXCoordinate(), i] = 3;
                    }
                }

                if (m.south != null)
                {
                    for (int i = (m.getYCoordinate() - 1); i > m.south.getYCoordinate(); i--)
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

                if (m.north != null)
                {
                    for (int i = (m.getYCoordinate() - 1); i > m.west.getYCoordinate(); i--)
                    {
                        maze[i, m.getYCoordinate()] = 3;
                    }
                }
            }
        }
    }

    class MazeJunction
    {
        int locationX = -1;
        int locationY = -1;

        public MazeJunction north { get; set; }
        public MazeJunction south { get; set; }
        public MazeJunction east { get; set; }
        public MazeJunction west { get; set; }

        public enum DirectionType
        {
            north,
            south,
            east,
            west,
        }

        public MazeJunction(int locationX, int locationY)
        {
            this.locationX = locationX;
            this.locationY = locationY;
            north = null;
            south = null;
            east = null;
            west = null;
        }

        public void addPath(DirectionType direction, MazeJunction connectorNode)
        {
            switch (direction)
            {
                case DirectionType.north:
                    north = connectorNode;
                    break;
                case DirectionType.south:
                    south = connectorNode;
                    break;
                case DirectionType.east:
                    east = connectorNode;
                    break;
                case DirectionType.west:
                    west = connectorNode;
                    break;
                default:
                    break;
            }
        }

        public int getXCoordinate()
        {
            return locationX;
        }

        public int getYCoordinate()
        {
            return locationY;
        }
    }
}
