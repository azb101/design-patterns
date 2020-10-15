using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Maze;

namespace Builder
{
    public class CountingMazeBuilder : IMazeBuilder
    {
        private Maze maze;
        
        public void BuildDoor(int a, int b)
        {
            var room1 = this.maze.RoomNo(a);
            var room2 = this.maze.RoomNo(b);

            var door = new Door(room1, room2);

            room1.SetSide(Direction.East, door);
            room2.SetSide(Direction.West, door);
        }

        public void BuildMaze()
        {
            this.maze = new Maze();
        }

        public void BuildRoom(int n)
        {
            if (this.maze.RoomNo(n) != null)
                throw new Exception("room already exist");

            var room = new Room(n);

            this.maze.AddRoom(room);
        }

        public Maze GetMaze()
        {
            return this.maze;
        }

        public virtual void AddWall(int n, Direction direction)
        {
            var room = this.maze.RoomNo(n);
            if (room == null)
                throw new Exception("room does not exist");

            room.SetSide(direction, new Wall());
        }
    }
}
