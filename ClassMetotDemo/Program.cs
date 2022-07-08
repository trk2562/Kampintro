namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Tarık";
            musteri1.SoyAd = "Yılmaz";
            musteri1.Id = 123456789;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Samet";
            musteri2.SoyAd = "Yılmaz";
            musteri2.Id = 987654321;

            Console.WriteLine("----------Metotlar------------");
            //Musteri[] musteris = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}