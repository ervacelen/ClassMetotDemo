using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123;
            musteri1.Adi = "Erva";
            musteri1.Soyadi = "Çelen";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 456;
            musteri2.Adi = "Engin";
            musteri2.Soyadi = "Demiroğ";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 789;
            musteri3.Adi = "Su";
            musteri3.Soyadi = "Denizci";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.MusteriEkle(musteri);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Lütfen silmek istediğiniz kişinin Id'sini giriniz");
            int silId = Convert.ToInt32(Console.ReadLine());
            foreach (Musteri musteri in musteriler)
            {
                if (musteri.Id == silId)
                {
                    musteriManager.MusteriSil(musteri);
                    break;

                }

            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Musteriler Listelendi");
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.MusteriListele(musteri);
            }
        }
    }
}
