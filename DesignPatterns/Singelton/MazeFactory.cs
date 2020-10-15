using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    public sealed class MazeFactory
    {
        private static readonly Lazy<MazeFactory> lazy =
            new Lazy<MazeFactory>(() =>
            {
                return new MazeFactory();
                // here should be added other types of MazeGame...
                // in if else manner
            });

        private MazeFactory() { }

        public static MazeFactory Instance { get { return lazy.Value; } }
    }
}
