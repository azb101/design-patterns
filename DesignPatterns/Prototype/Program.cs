using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Maze;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame game = new MazeGame();
            var simpleFactory = new MazePrototypeFactory(new Maze(), new Room(), new Door(), new Wall());
            var maze = game.CreateGame(simpleFactory);
            

            var bombedFactory = new MazePrototypeFactory(new Maze(), new Room(), new Door(), new BombedWall());
            var anotherMaze = game.CreateGame(bombedFactory);
        }
    }
}
