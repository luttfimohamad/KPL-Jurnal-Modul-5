using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204066
{
    internal class Program
    {
        static void Main(string[] args)
        {
			SayaTubeUser user = new SayaTubeUser("Lutfi");

			SayaTubeVideo film1 = new SayaTubeVideo("Review Film Kuntilanak Kepaduk oleh Lutfi");
			SayaTubeVideo film2 = new SayaTubeVideo("Review Film Cintaku Dibuang Kelaut oleh Lutfi");
			SayaTubeVideo film3 = new SayaTubeVideo("Review Film Kamu Santik Tapi Amis oleh Lutfi");
			SayaTubeVideo film4 = new SayaTubeVideo("Review Film Bagaikan Sakit Tapi Merana oleh Lutfi");
			SayaTubeVideo film5 = new SayaTubeVideo("Review Film Tukang ojek naik hajioleh Lutfi");
			SayaTubeVideo film6 = new SayaTubeVideo("Review Film Ada Apa Dengan Kamu oleh Lutfi");
			SayaTubeVideo film7 = new SayaTubeVideo("Review Film Munaroh Ketiban Untung oleh Lutfi");
			SayaTubeVideo film8 = new SayaTubeVideo("Review Film Sibat babat makan soto babat oleh Lutfi");
			SayaTubeVideo film9 = new SayaTubeVideo("Review Film Mataku kecipratan Obeng oleh Lutfi");
			SayaTubeVideo film10 = new SayaTubeVideo("Review Film JAngan lihat kebelakang oleh Lutfi");

			user.AddVideo(film1);
			user.AddVideo(film2);
			user.AddVideo(film3);
			user.AddVideo(film4);
			user.AddVideo(film5);
			user.AddVideo(film6);
			user.AddVideo(film7);
			user.AddVideo(film8);
			user.AddVideo(film9);
			user.AddVideo(film10);

			user.PrintAllVideoPlayCount();
		}
    }
}
