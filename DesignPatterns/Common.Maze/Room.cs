using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Maze
{
    public class Room : MapSite
    {
        private HashSet<MapSite> walls;
        public int Id { get; private set;  }

        public Room(int id)
        {
            this.walls = new HashSet<MapSite>();
            this.Id = id;
        }

        public Room()
        {
        }

        public new void Enter()
        {
            throw new NotImplementedException();
        }

        public MapSite GetSide(Direction direction)
        {
            foreach (Wall wall in walls)
            {
                if (wall.Direction == direction)
                    return wall;
            }

            throw new Exception("No such side for direction: " + direction);
        }

        public void SetSide(Direction direction, MapSite wall)
        {
            if (this.walls.Contains(wall))
                throw new Exception("Wall already presented ");

            if (!(wall is Wall))
                throw new Exception("Wall is not correct");

            ((Wall)wall).Direction = direction;

            this.walls.Add(wall);
        }
    }
}
