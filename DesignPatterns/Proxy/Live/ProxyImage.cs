using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Live
{
    class ProxyImage : Image
    {
        Image realImage;
        string filename;

        public ProxyImage(string filename)
        {
            this.filename = filename;
        }

        public void Display()
        {
            if (realImage == null)
                realImage = new RealImage(filename);

            realImage.Display();
        }
    }
}
