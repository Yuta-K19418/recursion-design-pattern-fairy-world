using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Themes
{
    internal interface ITheme
    {
        public string GetPoster();

        public string GetStringOfLights();

        public string LightShow();

        public MusicSong GetMusicSong();

        public Mascot[] GetMascots();
    }
}
