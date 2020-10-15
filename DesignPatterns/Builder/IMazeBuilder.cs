using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Maze;

namespace Builder
{
    public interface IMazeBuilder
    {
        void BuildMaze();

        void BuildRoom(int n);

        void BuildDoor(int a, int b);

        Maze GetMaze();
    }
}
