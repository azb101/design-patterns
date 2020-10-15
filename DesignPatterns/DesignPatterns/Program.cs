using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Maze;
using DesignPatterns.Bombed;
using DesignPatterns.Standard;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var standardMaze = CreateMaze(new MazeFactory());
            var bombedMaze = CreateMaze(new BombedMazeFactory());
        }

        static Maze CreateMaze(MazeFactory factory)
        {
            var maze = factory.MakeMaze();
            var room1 = factory.MakeRoom(1);
            var room2 = factory.MakeRoom(2);

            var door = factory.MakeDoor(room1, room2);


            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, factory.MakeWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, factory.MakeWall());
            room1.SetSide(Direction.West, factory.MakeWall());

            room2.SetSide(Direction.North, factory.MakeWall());
            room2.SetSide(Direction.East, factory.MakeWall());
            room2.SetSide(Direction.South, factory.MakeWall());
            room2.SetSide(Direction.West, door);

            return maze;
        }
    }
}
