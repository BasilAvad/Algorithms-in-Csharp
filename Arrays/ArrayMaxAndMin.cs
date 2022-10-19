using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    public class ArrayMaxAndMin
    {
        /// <summary>
        /// Parametre olarak aldigi dizinin en büyük elemanı bulr ve doner
        /// </summary>
        /// <param name="dizi">Dizi</param>
        /// <returns>Sonuc: Dizinin en buyuk elemanı</returns>
        public static int EnBuyuk(int[] dizi)
        {
            int eb = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > eb)
                {
                    eb = dizi[i];
                }
            }
            return eb;
        }
        /// <summary>
        /// Parametre olarak aldigi dizinin en küçük elemanı bulr ve doner
        /// </summary>
        /// <param name="dizi">Dizi</param>
        /// <returns>Sonuc: Dizinin en küçük elemanı</returns>
        public static int EnKucuk(int[] dizi)
        {
            int ek = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < ek)
                {
                    ek = dizi[i];
                }
            }
            return ek;
        }

        public static int Find(int[] integers)
        {
            var evenNumbers = integers.Where(integer => integer % 2 == 0);
            var oddNumbers = integers.Where(integer => integer % 2 == 1);
            return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();

        }
        public static double[] Tribonacci(double[] signature, int n)
        {
            double[] result = new double[n];
            if (n <= 3)
            {

                for (int a = 0; a < n; a++)
                {
                    result[a] = signature[a];
                }

            }
            else
            {

                for (int i = 0; i < signature.Length; i++)
                {
                    result[i] = signature[i];
                }

                for (int j = signature.Length; j < n; j++)
                {
                    result[j] = result[j - 3] + result[j - 2] + result[j - 1];
                }

            }

            return n==0?new double[n]:result;
        }
        public static void PrintMatrix2(double[] X)
        {
            Console.WriteLine();
            for (int i = 0; i < X.GetLength(0); i++)
            {
                Console.Write("{0,5}", X[i]+" ");
            }
            Console.WriteLine();
        }
    }
}

