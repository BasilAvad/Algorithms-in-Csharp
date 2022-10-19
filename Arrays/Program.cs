using ForLoop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array_Dizi array_Dizi = new Array_Dizi();
            //Console.Write(" Bir sayi girin :");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] X = new Array_Dizi().CreateArray(n);

            double[] Y = { 3, 1,1};
            double[] result = new double[11];
            
            ArrayMaxAndMin.PrintMatrix2(ArrayMaxAndMin.Tribonacci(Y,5));
            //Console.WriteLine(ArrayMaxAndMin.Find(result));  
            //int[] tekdizi = array_Dizi.TekDizi(X);
            //Console.WriteLine("----------");
            //array_Dizi.Yazdir(tekdizi);
            //int[] ciftdizi = array_Dizi.CiftDizi(X);
            //Console.WriteLine("----------");
            //array_Dizi.Yazdir(ciftdizi);
            //Console.WriteLine("Tek sayıların sayısı :{0,5}", array_Dizi.TekSayilarinSayisi(X));
            //Console.WriteLine("Çift sayıların sayısı :{0,5}", array_Dizi.CiftSayilarinSayisi(X));

            //Console.WriteLine("Dizinin Aretmetik ortalama  :{0:F3}"
            //    , Array_Dizi.AritmatikOrtalama(X));
            //Console.WriteLine("-------------");
            //Console.WriteLine("Dizinin Standart Sapma :{0:F3}"
            //    , Array_Dizi.StandartSapma(X));
            // Char ve rakam karsiliklari 
            //Console.WriteLine("");
            //for (int i = 65; i <=90; i++)
            //{
            //    Console.Write("{0,4}",(char)i);
            //    if (i%5==0)
            //        Console.WriteLine();
                
            //}
            //Console.WriteLine("");
            //String str1 = "Today is " + DateTime.Now.ToString("D") + ".";
            //Console.WriteLine(str1);
            Console.ReadLine();
        }

    }
}
