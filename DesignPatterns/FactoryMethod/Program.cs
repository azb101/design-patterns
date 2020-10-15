using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Maze;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var maze = CreateMaze(new MazeGame());
            var maze2 = CreateMaze(new BombedMazeGame());
        }

        private static Maze CreateMaze(MazeGame mazeGame)
        {
            return mazeGame.CreateMaze();
        }
    }
}
