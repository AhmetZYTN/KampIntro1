using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {


            // type safety - tip güvenliği c# ve javada önemli bir unsur olmakla birlikte type safety önde tutulur
            // Do not repeat yourself -- kendini tekralama
            //değer tutucu, alias(takma isim)
            string kategoriEtiketi = " Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("orta çizgi(değişmedi)");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine(" kullanıcı Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("giris yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
