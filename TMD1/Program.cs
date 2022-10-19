using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilen sayı = {0}",n);
            Console.WriteLine("Bir sayı giriniz");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilen sayı = {0}",f);
            //if (Number.TekMi(n))
            //{
            //    Console.WriteLine(" Girilen sayı = {0} tek bir sayıdır",n);


            //}
            //else if (Number.CiftMi(n))
            //{
            //        Console.WriteLine("Girilen sayı = {0} çift bir sayıdır", n);
            //}
            //Console.WriteLine(" |{0}| = {1}",n,Number.MutlakDeger(n));
            //Console.WriteLine("{0} ",
            //    Number.AsalMi(n)? "Asal sayıdır ": " Asal sayı değildir");
            //Console.WriteLine("Birden {0} Sayının rakamları toplami = {1}.",n,Number.N_KadarTekSayiBul(n));
            //Console.WriteLine("Birden {0} Sayının rakamları toplami = {1}.", n,Number.N_KadarTekSayiBul3(n));
            //Console.WriteLine("Birden {0} Sayının rakamları toplami = {1}.", n,Number.N_KadarTekSayiBul2(n));
            //Console.WriteLine("Birden {0} Sayının rakamları toplami = {1}.", n,Number.N_Kadar_Cift_Sayilar_Bul(n));
            //Console.WriteLine("Birden {0} Sayının rakamları toplami = {1}.", n,Number.N_Kadar_Cift_Sayilar_Bul2(n,f));
            Console.WriteLine("Birden {0} Sayının rakamları toplami = {1}.", n,Number.N_Kadar_Cift_Sayilar_Bul3(n));
            Console.WriteLine("Birden {0:F2} Sayının rakamları toplami = {1:F2}.", n,Circle.Daire_Alanı_Bul(n,f));

            




            Console.ReadLine();
        }
    }
}
