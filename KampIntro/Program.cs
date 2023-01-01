using System;
namespace _00KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 14;
            double faizOrani = 1.45;
            bool isLogin = false;
            double dolarBugun = 18.52;
            double dolarDun = 18.52;

            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Dolar kurunda yine artış var.");
            }
            else if (dolarBugun == dolarDun)
            {
                Console.WriteLine("Dolar kuru bugünlük sabit kaldı.");
            }
            else
            {
                Console.WriteLine("Dolar kurunda nihayet bir düşüş gözlemlendi.");
            }

            if (isLogin==true)
            {
                Console.WriteLine("\n...Kullanıcı Menüsü...");
            }
            else
            {
                Console.WriteLine("\nGiriş Yap");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOrani);
            Console.WriteLine(isLogin);
        }
    }
}