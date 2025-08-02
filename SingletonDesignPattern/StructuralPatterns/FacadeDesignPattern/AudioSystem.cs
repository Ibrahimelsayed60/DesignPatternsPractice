using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.FacadeDesignPattern
{
    public class AudioSystem
    {

        public void SetVolume(int level)
        {
            Console.WriteLine($"Audio set to {level}");
        }

    }
}
