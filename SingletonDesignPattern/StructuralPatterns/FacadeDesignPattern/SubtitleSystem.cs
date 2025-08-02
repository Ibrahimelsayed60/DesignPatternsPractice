using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.FacadeDesignPattern
{
    public class SubtitleSystem
    {

        public void LoadSubtitle(string lang)
        {
            Console.WriteLine($"Subtitles loaded: {lang}");
        }

    }
}
