using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Array_Dizi
    {
        /// <summary>
        /// tek boyutlu dizioluşturmak için kullanılan fonksiyon 
        /// </summary>
        /// <param name="limit">Dizinin uzunluğu belirtir </param>
        /// <returns> Belirtilen uzunlukta rastgele sayilardan olusmus diziyi doner</returns>
        public int[] CreateArray(int limit)
        {
            int[] Sayilar = new int[limit];
            Console.WriteLine("");
            for (int i = 0; i < Sayilar.Length; i++)
            {
                
                Sayilar[i] = new Random().Next(0, 100);
                Console.Write("{0,3}", Sayilar[i]);
            }
            Console.WriteLine("");


            return Sayilar;
        }

        /// <summary>
        /// Parametre olarak aldigi dizinin aritmetik ortalamasini hesaplar ve doner
        /// </summary>
        /// <param name="X"> Dizi </param>
        /// <returns> Aritmetik ortalama</returns>
        public static double AritmatikOrtalama(int[] X)
        {
            double toplam = 0;
            for (int i = 0; i < X.Length; i++)
            {
                toplam += X[i];
            }
            return toplam / X.Length;
        }
        /// <summary>
        /// Parametre olarak aldigi dizinin standart sapma hesaplar ve doner
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>Standart Sapma</returns>
        public static double StandartSapma(int[] X)
        {
            double aritmetikortalama = AritmatikOrtalama(X);
            double T = 0, f = 0;
            for (int i = 0; i < X.Length; i++)
            {
                f = X[i] - aritmetikortalama;
                T += Math.Pow(f, 2);
            }
            return Math.Sqrt(T / (X.Length - 1));
        }
        /// <summary>
        /// Bir dizideki tek sayiların sayısı döndüren algoritma
        /// </summary>
        /// <param name="X">X</param>
        /// <returns>Sonuc: Tek sayıların sayısını</returns>
        public int TekSayilarinSayisi(int[] X)
        {
            int tek = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 1)
                {
                    tek++;
                }
            }
            return tek;
        }
        /// <summary>
        /// Bir dizideki Çift sayiların sayısı döndüren algoritma
        /// </summary>
        /// <param name="X">X</param>
        /// <returns>Sonuc: Çift sayıların sayısını</returns>
        public int CiftSayilarinSayisi(int[] X)
        {
            int ceft = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    ceft++;
                }
            }
            return ceft;
        }
        /// <summary>
        /// Bir dizideki tek sayılardan yeni bir dizi olusturur
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>Tek sayılardan oluşan diziyi temsil eder .</returns>
        public int[] TekDizi(int[] X)
        {
            int y = 0;
            int[] tekdiizi = new int[TekSayilarinSayisi(X)];
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 1)
                {
                    tekdiizi[y] = X[i];
                    y++;
                }

            }
            return tekdiizi;
        }
        /// <summary>
        /// Bir dizideki çift sayılardan yeni bir dizi olusturur
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>Çift sayılardan oluşan diziyi temsil eder .</returns>
        public int[] CiftDizi(int[] X)
        {
            int y = 0;
            int[] ciftdiizi = new int[CiftSayilarinSayisi(X)];
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    ciftdiizi[y] = X[i];
                    y++;
                }

            }
            return ciftdiizi;
        }
        /// <summary>
        /// Parametre olarak aldigi dizi ekrana yazdırır
        /// </summary>
        /// <param name="X">Dizi</param>
        public void Yazdir(int[] X)
        {
            Console.WriteLine("");
            for (int i = 0; i < X.Length; i++)
            {
                Console.Write("{0,3}", X[i]);

            }
            Console.WriteLine("");
        }
    }
}
