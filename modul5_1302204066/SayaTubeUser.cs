using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204066
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideo;
        private string Username;

        public SayaTubeUser(string user)
        {
            this.id = new Random().Next(10000, 99999);
            this.uploadedVideo = new List<SayaTubeVideo>();
            this.Username = user;
        }

        public void GetTotalVideoplayCount()
        {
            int dataplayCount = 0;
            foreach (SayaTubeVideo v in uploadedVideo)
            {
                dataplayCount = dataplayCount + v.GetPlaycount();
            }
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideo.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("username:" + Username);
            for (int i = 0; i < 8; i++)
            {

                Console.WriteLine("video " + (i + 1) + " judul: " + uploadedVideo[i].GetTitle());
            }

        }
    }
}
