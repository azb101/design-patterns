using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Maze
{
    public class MazeGame
    {
        public Maze CreateMaze()
        {
            var maze = new Maze();

            var room1 = new Room(1);
            var room2 = new Room(2);
            var door1 = new Door(room1, room2);

            room1.SetSide(Direction.North, new Wall());
            room1.SetSide(Direction.East, door1);
            room1.SetSide(Direction.South, new Wall());
            room1.SetSide(Direction.West, new Wall());

            room2.SetSide(Direction.North, new Wall());
            room2.SetSide(Direction.East, new Wall());
            room2.SetSide(Direction.South, new Wall());
            room2.SetSide(Direction.West, door1);

            return maze;
        }
    }
}
