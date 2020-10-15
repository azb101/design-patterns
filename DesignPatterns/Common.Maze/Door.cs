using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Maze
{
    public class Door : MapSite
    {
        Room room1;
        Room room2;

        public Door(Room room1, Room room2)
        {
            this.room1 = room1;
            this.room2 = room2;
        }

        public Door(Door door)
        {
            room1 = door.room1;
            room2 = door.room2;
        }

        public Door()
        {
        }

        public new void Enter()
        {
            
        }

        public Room OtherSideFrom(Room room)
        {
            throw new NotImplementedException();
        }

        public virtual Door Clone()
        {
            return new Door(this);
        }

        public void Initialize(Room room1, Room room2)
        {
            this.room1 = room1;
            this.room2 = room2;
        }
    }
}
