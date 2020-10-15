using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Maze;

namespace Builder
{
    public class StandardMazeBuilder : IMazeBuilder
    {
        private Maze maze;

        public StandardMazeBuilder()
        {
        }

        public void BuildDoor(int a, int b)
        {
            var room1 = maze.RoomNo(a);
            var room2 = maze.RoomNo(b);

            var door = new Door(room1, room2);

            room1.SetSide(CommonWall(room1, room2), door);
            room2.SetSide(CommonWall(room2, room1), door);
        }

        public void BuildMaze()
        {
            this.maze = new Maze();
        }

        public void BuildRoom(int n)
        {
            if (this.maze.RoomNo(n) != null)
                throw new Exception("room already presented");

            var room = new Room(n);
            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.West, new Wall());

            this.maze.AddRoom(room);
        }

        public Maze GetMaze()
        {
            return this.maze;
        }

        private Direction CommonWall(Room room1, Room room2)
        {
            return (Direction)new Random().Next(0, 3);
        }
    }
}
