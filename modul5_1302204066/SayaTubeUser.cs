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
        public string Username;

        public SayaTubeUser(string user)
        {
            this.id = new Random().Next(10000, 99999);
            this.uploadedVideo = new List<SayaTubeVideo>();
            if (user.Length > 100 && user == null)
                throw new Exception("Username yang anda masukkan salah");
            this.Username = user;
        }

        public void GetTotalVideoplayCount()
        {
            int dataplayCount = 0;
            foreach (SayaTubeVideo v in uploadedVideo)
            {
                try
                {
                    dataplayCount = checked(dataplayCount + v.GetPlayCount());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
        }

        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null)
                throw new Exception("Anda tidak memasukkan video");
            if (video.GetPlayCount() > 1000000000)
                throw new Exception("Play count yang anda masukkan melebihi batas maksimum");
            uploadedVideo.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("username : " + Username);
            for (int i = 0; i < 8; i++)
            {

                Console.WriteLine("video " + (i + 1) + " judul: " + uploadedVideo[i].GetTitle());
            }

        }
    }
}
