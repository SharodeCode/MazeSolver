using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    class MazeGraph
    {
        int[,] maze = null;
        public MazeJunction startJunction { get; set; }
        public MazeJunction endJunction { get; set; }
        List<MazeJunction> junctions = new List<MazeJunction>();

        // Used to detect when a pathways is needed
        bool eastClear;
        MazeJunction westNode = null;

        List<MazeJunction> verticalJunctions = new List<MazeJunction>();

        public MazeGraph(int[,] maze)
        {
            this.maze = maze;
            createConnections();
        }

        public List<MazeJunction> getJunctions()
        {
            return junctions;
        }

        private void createConnections()
        {
            // Add start junction
            for (int i = 1; i < (maze.GetLength(0) - 1); i++)
            {
                if (maze[i, 0] == 1)
                {
                    MazeJunction newJunction = new MazeJunction(i, 0);

                    verticalJunctions.Add(newJunction);

                    junctions.Add(newJunction);
                    startJunction = newJunction;
                }
            }

            for (int i = 1; i < (maze.GetLength(1) - 1); i++)
            {
                for (int j = 1; j < (maze.GetLength(0) - 1); j++)
                {
                    if (maze[j, i] == 1)
                    {
                        if (checkJunction(j, i))
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

            // Add end junction
            for (int i = 1; i < (maze.GetLength(0) - 1); i++)
            {
                if (maze[i, (maze.GetLength(1) - 1)] == 1)
                {
                    MazeJunction newJunction = new MazeJunction(i, (maze.GetLength(1) - 1));

                    newJunction.addPath(MazeJunction.DirectionType.north, verticalJunctions.First());
                    verticalJunctions.First().addPath(MazeJunction.DirectionType.south, newJunction);

                    verticalJunctions.Remove(verticalJunctions.First());

                    junctions.Add(newJunction);

                    endJunction = newJunction;
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
            MazeJunction northJunction = null;

            if (maze[newJunction.getXCoordinate(), (newJunction.getYCoordinate() - 1)] != 0)
            {
                foreach (MazeJunction junction in verticalJunctions)
                {
                    if (junction.getXCoordinate() == newJunction.getXCoordinate())
                    {
                        newJunction.addPath(MazeJunction.DirectionType.north, junction);
                        junction.addPath(MazeJunction.DirectionType.south, newJunction);

                        northJunction = junction;
                    }
                }
            }

            if (northJunction != null)
            {
                verticalJunctions.Remove(northJunction);
            }

            if (maze[newJunction.getXCoordinate(), (newJunction.getYCoordinate() + 1)] == 1)
            {
                verticalJunctions.Add(newJunction);
            }
        }

        private void connectWest(MazeJunction newJunction)
        {
            if (eastClear == true)
            {
                newJunction.addPath(MazeJunction.DirectionType.west, westNode);
                westNode.addPath(MazeJunction.DirectionType.east, newJunction);
            }
        }

        public void ResetJunctions()
        {
            foreach(MazeJunction junction in junctions)
            {
                junction.visited = false;
            }
        }
    }
}
