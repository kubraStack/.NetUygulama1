using System;

namespace Uygulama1Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uygulama 

            int x = 2, y = 5, z = 10;

            // a-) Kullanıcıdan aldığınız 2 sayının çarpımı ile x,y,z toplamının farkı nedir?
                // System.Console.WriteLine("1.sayı: ");
                // int sayi1 = int.Parse(Console.ReadLine());

                // System.Console.WriteLine("2.sayı: ");
                // int sayi2 = int.Parse(Console.ReadLine());

                // int sonuc = (sayi1 * sayi2) - (x+y+z);
                // System.Console.WriteLine("sonuc: " + sonuc);
            // b-) Kullanıcıdan alınan bir sayının tek çift kontrolünü yapınız.
                // System.Console.WriteLine("sayı: ");
                // int sayı = int.Parse(Console.ReadLine());


                // string sonuc = (sayı % 2) == 0 ? "çift":"tek";
                // System.Console.WriteLine($"Girilen sayı çift mi ? {sonuc}");

            // c-) (x,y,z) toplamının mod 3'ü kaçtır ?
                // var sonuc = (x+y+z)%3;
                // System.Console.WriteLine("Sonuc: " + sonuc);

            // d-) y'nin x. kuvvetini hesaplayınız.
                var sonuc = Math.Pow(x,y);
                System.Console.WriteLine("Sonuc : " + sonuc);

        }
    }
}
