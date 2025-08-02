using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.FacadeDesignPattern
{
    public class VideoSystem
    {

        public void SetResolution(string res)
        {
            Console.WriteLine($"Resolution set to {res}");
        }

    }
}
