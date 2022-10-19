using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD1
{
    public class Number
    {
        /// <summary>
        /// Girilen sayı tek mi çift mi belirleyen prpgram
        /// </summary>
        /// <param name="s">Sayı </param>
        /// <returns> tek ist True </returns>
        public static bool TekMi(int s)
        {
            if (s % 2 == 1)
            {
                return true;

            }
            return false;
        }
        public static bool CiftMi(int s)
        {
            if (s % 2 == 0)
            {
                return true;

            }
            return false;
        }
        public static int MutlakDeger(int n)
        {
            if (n > 0)
            {
                return n;
            }
            else if (n < 0)
            {
                return -1 * n;

            }
            else
                return 0;

        }
        public static bool AsalMi(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine(" En kuçuk asal sayı ikidir ");
                return false;
            }
            bool kontrol = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    kontrol = false;
                    break;
                }
            }
            return kontrol;

        }
        public static int RakamlarToplami(int n)
        {
            int toplama = 0, rakam = 0;
            while (n > 0)
            {
                rakam = n % 10;
                toplama += rakam;// Depolama kısmı ilk 5 + 3 + 2
                n = n / 10;
            }
            return toplama;
        }
        public static double N_KadarOlanSayıTopla(double n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                t += i;
            }
            return t;
        }
        public static double N_KadarOlanSayıTopla2(double n)
        {
            return (n * (n + 1) / 2);
        }
        public static int N_KadarTekSayiBul(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    t += i;
                }
            }

            return t;
        }
        public static int N_KadarTekSayiBul2(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i += 2)
            {
                t += i;
            }
            return t;
        }
        public static int N_KadarTekSayiBul3(int n)
        {
            n++;
            n = n / 2;
            return n * n;
        }
        /// <summary>
        /// Birden N'e kadar çift sayıların toplamı 
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Çift sayıların toplamı </returns>
        public static int N_Kadar_Cift_Sayilar_Bul(int n)
        {
            int t = 0;
            for (int i = 0; i <= n; i += 2)
            {
                t += i;
            }
            return t;
        }
        /// <summary>
        /// negatiften Pozitife çift sayıları toplayan program 
        /// </summary>
        /// <param name="n">Pozitif</param>
        /// <param name="f"> Nigatif </param>
        /// <returns>Çift sayıların toplamı </returns>
        public static int N_Kadar_Cift_Sayilar_Bul2(int n, int f)
        {
            int t = 0;
            int g = 0;
            for (int i = f; i <= 0; i++)
            {

                if (i % 2 == 0)
                {

                    g += i;
                    
                }

            }
            for (int i = 0; i <=n; i++)
            {
                if (i % 2 == 0)
                {

                    t += i;

                }
            }
            return (g*-1)+ t;
            
        }
        public static int N_Kadar_Cift_Sayilar_Bul3(int n)
        {

            n = n / 2;
            return n * (n + 1);
        }

       public static void BinaryToDecimal(string BinaryNumber)
        {
            int n = BinaryNumber.Length;
            int[] DigitsOfNumbe = new int[n];
            bool control = true;
            int Number = 0;
            for (int i = 0; i < n; i++)
            {
                if (!(BinaryNumber[i]=='0'|| BinaryNumber[i] == '1'))
                {
                    Console.WriteLine("\a Hatali Giris");
                    control = false;
                    break;
                }
                DigitsOfNumbe[i] =(int)( BinaryNumber[i] - '0');
            }
            if (control)
            {
                for (int i = 0; i < n; i++)
                {
                    Number += (int)Math.Pow(2, n - 1 - i) * DigitsOfNumbe[i];
                }
                Console.WriteLine("{0} Binary to Decimal = {1}",BinaryNumber,Number);
            }
        }
    }
}
