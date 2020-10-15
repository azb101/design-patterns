using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Maze;

namespace FactoryMethod
{
    public class BombedMazeGame : MazeGame
    {
        public override Room MakeRoom(int n)
        {
            return new BombedRoom(n);
        }

        public override Wall MakeWall()
        {
            return new BombedWall();
        }
    }
}
