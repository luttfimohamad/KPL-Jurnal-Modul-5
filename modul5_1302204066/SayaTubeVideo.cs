using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204066
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo (string video)
        {
            this.id = new Random().Next(10000, 99999);
            this.playCount = 0;
            if (video.Length > 200 && video == null)
                throw new Exception("Judul yang anda masukkan salah");
            this.title = video;
        }

        public void IncreasePlayCount(int playCount)
        {
            if (playCount > 25000000 && playCount < 0)
                throw new Exception("Play count yang anda masukkan melebihi batas maksimal");
            this.playCount = checked(this.playCount + playCount);
        }

        public int GetPlayCount()
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
