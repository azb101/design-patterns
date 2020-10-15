using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Maze;

namespace Prototype
{
    public class MazePrototypeFactory : MazeFactory
    {
        private Maze mazeProto;
        private Room roomProto;
        private Door doorProto;
        private Wall wallProto;
        
        public MazePrototypeFactory(Maze mazeProto, Room roomProto, Door doorProto, Wall wallProto)
        {
            this.mazeProto = mazeProto;
            this.roomProto = roomProto;
            this.doorProto = doorProto;
            this.wallProto = wallProto;
        }
        
        public override Door MakeDoor(Room room1, Room room2)
        {
            var door = doorProto.Clone();
            door.Initialize(room1, room2);
            return door;
        }

        public override Wall MakeWall()
        {
            return wallProto.Clone();
        }
    }
}
