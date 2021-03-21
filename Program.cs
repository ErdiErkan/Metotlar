using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 85;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            // type-safe  -- tip güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("-----------Metotlar------------------");

            // instance - örnek
            //encapsulation


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12);

        }
    }
}

// Dont repeat yourself
// Dont repeat yourself - DRY - Clean Code - Best Practice