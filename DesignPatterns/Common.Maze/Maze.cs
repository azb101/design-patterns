using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Maze
{
    public class Maze 
    {
        private HashSet<Room> rooms;

        public Maze()
        {
            this.rooms = new HashSet<Room>();
        }

        public void AddRoom(Room room)
        {
            if (rooms.Contains(room))
                throw new Exception("Room are already in maze");

            rooms.Add(room);
        }

        public Room RoomNo(int id)
        {
            foreach (var item in rooms)
            {
                if (item.Id == id)
                    return item;
            }

            throw new Exception("room not found with id: " + id);
        }
    }
}
