using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal class Song
    {
        private string name;
        private string author;
        public Song prev;

        public Song()
        {
            this.name = "Название песни";
            this.author = "Автор песни";
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public void SetPrev(Song prev)
        {
            this.prev = prev;
        }

        public void SongInfo()
        {
            Console.WriteLine($"Название песни: {name}, Автор песни: {author}");
        }

        public string Title()
        {
            return $"{name} + {author}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Song otherSong)
            {
                return this.name == otherSong.name && this.author == otherSong.author;
            }
            return false;
        }
    }
}
