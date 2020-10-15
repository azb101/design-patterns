using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Live
{
    public class RealImage : Image
    {
        private string filename;

        public RealImage(string filename)
        {
            this.filename = filename;
            loadFromDisk(filename);
        }

        private void loadFromDisk(string filename)
        {
            Console.WriteLine($"Loading from disk : {filename}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying: {filename}");
        }
    }
}
