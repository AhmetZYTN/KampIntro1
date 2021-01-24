using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string UrunAdi = "elma";
            //double fiyati = 15;
            //string aciklama = "Amasya elması";

           // string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdedi = 8;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "Diyarbakır";
            urun2.stokAdedi = 7;

            Urun urun3 = new Urun();
            urun3.Adi = "mango";
            urun3.Fiyatı = 20;
            urun3.Aciklama = "afrikadan geldi";

            Urun[] urunler = new Urun[] {urun1, urun2, urun3 };

            //type-safe -- tip güvenliği
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı + "$");
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("-------------Metodlar--------------");
            //encapsulation
            //instance - örneek

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 845521, 7);
            sepetManager.Ekle2("Elma", "sfdsfds", 42, 78);
            sepetManager.Ekle2("mango", "ghxgf", 785, 2);
            sepetManager.Ekle2("çilek", "gszfg", 42, 8);
        }
    }
}


// Dont repeat yourself - DRY - Clean code - Best Practice