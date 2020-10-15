using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Maze;
using DesignPatterns.Standard;

namespace DesignPatterns.Enchanced
{
    public class EnchansedMazeFactory : MazeFactory
    {
        protected Spell CastSpell()
        {
            return new Spell();
        }

        public override Room MakeRoom(int n)
        {
            return new EnchancedRoom(n);
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            return new DoorNeedingSpell(room1, room2);
        }
    }
}
