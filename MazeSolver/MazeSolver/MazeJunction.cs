using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
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
