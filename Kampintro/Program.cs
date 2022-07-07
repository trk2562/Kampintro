using System;

namespace KampIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            // type safety: tip güvenliği (Bişi tanımlamak istiyorsan önüne veri tipini yazmalısın.)
            // Do not repeat your self.
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;



            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu.");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu.");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu.");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}