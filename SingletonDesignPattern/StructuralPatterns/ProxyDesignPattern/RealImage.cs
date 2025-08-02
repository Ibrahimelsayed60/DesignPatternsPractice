using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.ProxyDesignPattern
{
    public class RealImage : IImage
    {
        private string _fileName;
        public RealImage(string fileName)
        {
            _fileName = fileName;
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading {_fileName} from disk ....");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying {_fileName}");
        }
    }
}
