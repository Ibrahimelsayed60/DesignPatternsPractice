using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.FacadeDesignPattern
{
    public class MoviePlayerFacade
    {

        private readonly AudioSystem _audio = new();
        private readonly VideoSystem _video = new();
        private readonly SubtitleSystem _subtitle = new();

        public void PlayMovie()
        {
            _audio.SetVolume(50);
            _video.SetResolution("1080p");
            _subtitle.LoadSubtitle("Arabic");
            Console.WriteLine("Playing movie ....");
        }

    }
}
