using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Maze;

namespace Builder
{
    public class MazeGame
    {
        private IMazeBuilder builder;

        public MazeGame(IMazeBuilder builder)
        {
            this.builder = builder;
        }

        public Maze CreateMaze()
        {
            builder.BuildMaze();

            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            return this.builder.GetMaze();
        }
    }
}
