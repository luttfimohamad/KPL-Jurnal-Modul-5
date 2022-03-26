using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204066
{
    internal class SayaTubeVideo
    {
        int id;
        string title;
        int playCount;

        public SayaTubeVideo (string video)
        {
            this.id = new Random().Next(10000, 99999);
            this.playCount = 0;
            this.title = video;
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount = (this.playCount + playCount);
        }

        public int GetPlaycount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Song ID\t\t: " + this.id);
            Console.WriteLine("Song Title\t: " + this.title);
            Console.WriteLine("Playcount\t: " + this.playCount + "\n");
        }
    }
}
