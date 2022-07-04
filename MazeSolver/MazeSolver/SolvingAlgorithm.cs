using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    class SolvingAlgorithm
    {

        public SolvingAlgorithm()
        {

        }

        public List<MazeJunction> BreadthFirst(Maze maze)
        {
            List<MazeJunction> solution = new List<MazeJunction>();

            Dictionary<MazeJunction, MazeJunction> parents = new Dictionary<MazeJunction, MazeJunction>();

            MazeJunction s = maze.getStartJunction();

            LinkedList<MazeJunction> queue = new LinkedList<MazeJunction>();

            s.visited = true;
            queue.AddLast(s);

            while (queue.Any())
            {
                s = queue.First();

                queue.RemoveFirst();

                if (s.Equals(maze.getEndJunction()))
                {
                    break;
                }

                LinkedList<MazeJunction> list = new LinkedList<MazeJunction>();
                list.AddLast(s.north);
                list.AddLast(s.south);
                list.AddLast(s.east);
                list.AddLast(s.west);

                if (s.north != null && !parents.ContainsKey(s.north))
                {
                    parents.Add(s.north, s);
                }

                if (s.south != null && !parents.ContainsKey(s.south))
                {
                    parents.Add(s.south, s);
                }

                if (s.east != null && !parents.ContainsKey(s.east))
                {
                    parents.Add(s.east, s);
                }

                if (s.west != null && !parents.ContainsKey(s.west))
                {
                    parents.Add(s.west, s);
                }


                foreach (MazeJunction val in list)
                {
                    if (val != null && !val.visited)
                    {
                        val.visited = true;
                        queue.AddLast(val);
                    }
                }
            }


            MazeJunction parent = s;

            while (parent != maze.getStartJunction())
            {
                solution.Add(parent);
                parent = parents[parent];
            }

            return solution;
        }
    }
}
