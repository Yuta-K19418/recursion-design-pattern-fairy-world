using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Themes
{
    internal class MusicSong
    {
        internal string SongTitle;

        internal string Lyrics;

        internal TimeSpan SongLength;

        internal MusicSong(string songTitle, string lyrics, TimeSpan songLength)
        {
            this.SongTitle = songTitle;
            this.Lyrics = lyrics;
            this.SongLength = songLength;
        }
    }
}
