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

        public Maze(int[,] maze)
        {
            this.maze = maze;
            initialise();
        }

        public void initialise()
        {
            for (int i = 0; i < maze.GetLength(1); i++)
            {
                for (int j = 0; j < maze.GetLength(0); j++)
                {
                    if(maze[j, i] == 1)
                    {
                        if(checkJunction(j, i))
                        {
                            maze[j, i] = 2;
                        }
                    }

                }
            }  
        }

        bool checkJunction(int x, int y)
        {
            bool result = true;


            return result;
        }

        public int[,] getMazeArray()
        {
            return maze;
        }
    }

    class MazeJunction
    {
        int locationX = -1;
        int locationY = -1;

        MazeJunction north = null;
        MazeJunction south = null;
        MazeJunction east = null;
        MazeJunction west = null;

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
        }

        public void addPath(DirectionType direction)
        {

        }
    }
}
