using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Maze;

namespace Prototype
{
    public class MazeGame
    {
        public Maze CreateGame(MazePrototypeFactory mazePrototypeFactory)
        {
            var maze = mazePrototypeFactory.MakeMaze();

            return maze;
        }
    }
}
