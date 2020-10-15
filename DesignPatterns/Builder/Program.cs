using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var mazeDirector = new MazeGame(new StandardMazeBuilder());
            var maze = mazeDirector.CreateMaze();

            var anotherMazeDirector = new MazeGame(new CountingMazeBuilder());
            var anotherMaze = anotherMazeDirector.CreateMaze();
        }
    }
}
