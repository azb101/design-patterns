﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Maze;

namespace DesignPatterns.Enchanced
{
    public class DoorNeedingSpell : Door
    {
        public DoorNeedingSpell(Room room1, Room room2) : base(room1, room2)
        {

        }
    }
}
