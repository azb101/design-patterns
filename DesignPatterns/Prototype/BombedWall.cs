using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Maze;

namespace Prototype
{
    public class BombedWall : Wall
    {
        bool hasBomb;

        public BombedWall()
        {

        }

        public BombedWall(BombedWall wall) : base(wall)
        {

        }

        public override Wall Clone()
        {
            return new BombedWall(this);
        }
    }
}
