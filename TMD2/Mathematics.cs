using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD2
{
    public class Mathematics
    {
        /// <summary>
        /// Parametre olarak aldigi taban ve kuvvet bagli olarak ustAlma 
        /// </summary>
        /// <param name="A">Taban </param>
        /// <param name="B">Kuvvet </param>
        /// <returns></returns>
        public static double UstAlma(double A, double B)
        {
            double s = 1;
            for (int i = 0; i <= B; i++)
            {
                s *= A;
            }
            return s;
        }
        /// <summary>
        /// Bir sayının asal çarpanı verir.
        /// </summary>
        /// <param name="m">Sayiyi temsil eder</param>
        /// <returns>Asal carpanlar dizisidir </returns>
        public static int[] PrimeNumbersMultiplier(int m)
        {
            //Asal carpanları verir 
            string MultiplierList = "";
            int d = 2;
            while (m > 1)
            {
                if (m % d == 0)
                {
                    m = m / d;
                    MultiplierList += d.ToString() + ",";
                }
                else
                    d++;
            }
            MultiplierList = MultiplierList.Substring(0, MultiplierList.Length - 1);
            string[] multiplierLists = MultiplierList.Split(',');
            //Tekrar edilen asal carpanı geri dondurmez matriks içerisinde . 
            string s = multiplierLists[0];
            string y = s;
            for (int i = 0; i < multiplierLists.Length; i++)
            {
                if (!(s == multiplierLists[i]))
                {
                    y += "," + multiplierLists[i];
                    s = multiplierLists[i];

                }
            }
            // From String [] to int[] 
            multiplierLists = y.Split(',');
            int[] PrimeNumbersMultiplier = new int[multiplierLists.Length];
            for (int i = 0; i < PrimeNumbersMultiplier.Length; i++)
                PrimeNumbersMultiplier[i] = Convert.ToInt32(multiplierLists[i]);


            return PrimeNumbersMultiplier;
        }
        /// <summary>
        /// Bir sayinin asal carpanlarinin toplamini verir .
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>Toplam</returns>
        public static int AsalCarpanlarinToplami(int n)
        {
            int[] AsalCarpan = Mathematics.PrimeNumbersMultiplier(n);
            int t = 0;
            for (int i = 0; i < AsalCarpan.Length; i++)
            {
                t += AsalCarpan[i];

            }
            return t;

        }
        /// <summary>
        /// Bir sayinin asal carpanlarinin carpımını verir .
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>Carpim sonucu</returns>
        public static int AsalCarpanlarinCarpimi(int n)
        {
            int[] AsalCarpan = Mathematics.PrimeNumbersMultiplier(n);
            int c = 1;
            for (int i = 0; i < AsalCarpan.Length; i++)
            {
                c *= AsalCarpan[i];

            }
            return c;

        }
        /// <summary>
        /// Ortak katların en kucugunu hesplar
        /// </summary>
        /// <param name="s1">Birinci Sayi</param>
        /// <param name="s2">İkinci Sayi</param>
        /// <returns>OKEK Sonucu</returns>
        public static int OKEK(int s1, int s2)
        {
            int s = 1;
            string MultiplierList = "";
            while (s1 != 1 && s2 != 1)
            {
                int t = 2;
                for (int i = 1; i <= (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % t == 0 || s2 % t == 0)
                    {
                        s *= t;
                        if (s1 % t == 0)
                        {
                            s1 = s1 / t;
                            MultiplierList += t.ToString() + ",";
                        }
                        if (s2 % t == 0)
                        {
                            s2 = s2 / t;
                            MultiplierList += t.ToString() + ",";
                        }

                    }
                    else
                        t++;

                }

            }
            MultiplierList = MultiplierList.Substring(0, MultiplierList.Length - 1);
            string[] multiplierLists = MultiplierList.Split(',');
            Console.WriteLine(multiplierLists);
            return s;

        }
        /// <summary>
        /// En Buyuk Ortak Bolen hesplar
        /// </summary>
        /// <param name="s1">Birinci Sayi</param>
        /// <param name="s2">İkinci Sayi</param>
        /// <returns>OBEB Sonucu</returns>
        public static int OBEB(int s1, int s2)
        {
            int s = 1;
            int bolen = 2;
            while (s1 != 1 && s2 != 1)
            {
                for (int i = 2; i < (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % bolen == 0 || s2 % bolen == 0)
                    {
                        if (s1 % bolen == 0 && s2 % bolen == 0)
                            s *= bolen;
                        if (s1 % bolen == 0)
                        {
                            s1 /= bolen;
                        }
                        if (s2 % bolen == 0)
                        {
                            s2 /= bolen;
                        }
                    }
                    else
                        bolen++;
                }

            }
            return s;
        }
        /// <summary>
        /// A factorial is a function that multiplies a number by every number below it. For example 5!= 5*4*3*2*1 ...
        /// </summary>
        /// <param name="n">number</param>
        /// <returns>Number factorial </returns>
        public static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            int f = 1;
            for (int i = 2; i <= n; i++)
            {
                f *= i;
            }
            return f;

        }
        /// <summary>
        /// 0-9 kadar olan sayıların faktoryeleri toplayıp bolu sayıların sayısı
        /// Exampel (1!+2!+3!+4!)/4
        /// </summary>
        /// <param name="n"></param>
        /// <returns> Average</returns>
        public static int Factorial2(int n)
        {
            int t = 0;
            int z = 0;
            for (int i = 0; i <= n; i++)
            {
                int c = Mathematics.Factorial(i);
                t += c;
                Console.WriteLine("{0}! = {1}", i, c);
                z++;
            }
            int average = t / z;
            return average;
        }
        /// <summary>
        /// Girilen sayılar Diziye atar.
        /// Örnek sayaılar boyle girilrir 12,23,15,20
        /// </summary>
        /// <param name="A">İfade</param>
        /// <returns>Array</returns>
        public int[] IfadiyeDiziyeCevir(string A)
        {
            string[] AMKBOL = A.Split(',');
            int n = AMKBOL.Length;
            int[] SayiDizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                SayiDizisi[i] = Convert.ToInt32(AMKBOL[i]);
                Console.WriteLine("The Index [{0}] of array is ={1}", i, SayiDizisi[i]);
            }
            return SayiDizisi;
        }
        /// <summary>
        /// Convert any binary number (base-2 (0 or 1)) into decimal number (base-10 (0 to 9)) by C# program.
        /// </summary>
        /// <param name="Binary">Binary Number</param>
        /// <returns></returns>
        public static int BinaryToDecimalConverter(string Binary)
        {
            int n = Binary.Length;
            int[] DigitsOfNumbers = new int[n];
            int number = 0;
            bool Control = true;
            for (int i = 0; i < n; i++)
            {
                if (!(Binary[i] == '0' || Binary[i] == '1'))
                {
                    Console.WriteLine("\aHatali giris");
                    Control = false;
                    break;
                }
                //Convert the char to int
                // Ornek 1 char olarak tanımlanmıs ise karsiligi 49 int
                // Ornek 0 char olarak tanımlanmıs ise karsiligi 48 int
                DigitsOfNumbers[i] = (int)(Binary[i] - '0');
                // Digit = 49-48= 1   DigitsOfNumber birinci elemanı 
                // Digit = 48-48= 0   DigitsOfNumber birinci elemanı 
            }
            if (Control)
            {
                for (int i = 0; i < n; i++)
                {
                    number += (int)Math.Pow(2, n - 1 - i) * DigitsOfNumbers[i];
                }
                Console.WriteLine("{0} Binary Number in Decimal is = {1}", Binary, number);
            }
            return number;
        }
        /// <summary>
        ///  Convert any decimal number (base-10 (0 to 9)) into binary number (base-2 (0 or 1)) by C# program.
        /// </summary>
        /// <param name="DecimalNumber">Decimal Number</param>
        public static void DecimalToBinary(int DecimalNumber)
        {
            int i;
            int[] a = new int[DecimalNumber];

            for (i = 0; DecimalNumber > 0; i++)
            {
                a[i] = DecimalNumber % 2;
                DecimalNumber = DecimalNumber / 2;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            
        }
    }

}

