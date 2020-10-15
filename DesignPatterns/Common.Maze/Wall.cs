using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Maze
{
    public class Wall : MapSite
    {
        public Wall()
        {

        }

        public Wall(Wall wall)
        {

        }

        public Direction Direction { get; set; }

        public new void Enter()
        {
            throw new NotImplementedException();
        }

        public virtual Wall Clone()
        {
            return new Wall(this);
        }
    }
}
