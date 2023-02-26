using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TVuygulaması
    {

        public int sesseviyesi;
        public int kanal;

        public void kdegistir()
        {
            Console.WriteLine("1 TRT1");
            Console.WriteLine("2 FOX");
            Console.WriteLine("3 ATV");
            Console.WriteLine("4 A2");
            Console.WriteLine("5 SHOW");
            Console.WriteLine("6 Star Tv");
            Console.WriteLine("7 TV8");
            Console.WriteLine("8 GS TV");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TVuygulaması t1 = new TVuygulaması();


            Console.WriteLine("Televizyonu açmak için 1'e basınız. ");
            int TVac = Convert.ToInt32(Console.ReadLine());
            if (TVac == 1)
            {
                Console.WriteLine("Televizyon açılıyor.");
            }
            else
            {
                Console.WriteLine("Yanlış şifre. Tekrar deneyiniz.");
            }


            Console.Clear();

            Console.WriteLine("Kanal listesi için A'ya basınız.");
            string kanallar = Convert.ToString(Console.ReadLine());
            if (kanallar == "A")
            {
                t1.kdegistir();
                Console.WriteLine("kanal seçiniz: ");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    Console.WriteLine("TRT1");
                }
                if (secim == 2)
                {
                    Console.WriteLine("FOX");
                }
                if (secim == 3)
                {
                    Console.WriteLine("ATV");
                }
                if (secim == 4)
                {
                    Console.WriteLine("A2");
                }
                if (secim == 5)
                {
                    Console.WriteLine("SHOW");
                }
                if (secim == 6)
                {
                    Console.WriteLine("Star Tv");
                }
                if (secim == 7)
                {
                    Console.WriteLine("Tv8");
                }
                if (secim == 8)
                {
                    Console.WriteLine("GS TV");
                }
            }
            else
            {
                Console.WriteLine("Hatalı Tuşlama Yaptınız");
            }
            string sesseviyesi = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ses seviyesini arttırmak için J'yi tuşlayın.");
            if (sesseviyesi == "J")
            {
                Console.WriteLine("Ses seviyeniz fullendi. Azaltmak isterseniz K'ye basınız.");
            }

            string sesazaltma = Convert.ToString(Console.ReadLine());
            if (sesazaltma == "K")
            {
                Console.WriteLine("Ses seviyeniz düşürüldü.");
            }

            Console.WriteLine("Televizyonu kapatmak için 0'a basınız.");
            int TVkapa = (Convert.ToInt32(Console.ReadLine()));
            if (TVkapa == 0)
            {
                Console.WriteLine("Televizyon Kapanıyor...");
            }
            Console.ReadKey();
        }
    }
}
