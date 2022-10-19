using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD2
{

    class Program
    {
        static void Main(string[] args)
        {
            //StringExamples.Pattern1('d', 12);
            //StringExamples.Pattern2('d', 12);
            //StringExamples.Pattern3(0,255,10);
            Console.WriteLine("------------");
            ////Console.WriteLine( Mathematics.UstAlma(2, 3));
            //int[] AsalCarpan = Mathematics.PrimeNumbersMultiplier(60);
            //int t = 0;
            //for (int i = 0; i < AsalCarpan.Length; i++)
            //{
            //    t += AsalCarpan[i];

            //}
            //Console.WriteLine("{0} Sayinin asal carpanlarinin toplami = {1}", 60, t);
            //Console.WriteLine("OKEK {0}", Mathematics.OKEK(10, 30));
            //Console.WriteLine("OBEB {0}", Mathematics.OBEB(10, 10));
            //int n = 16;
            //Console.WriteLine("{0}!/n Factorial/n is = {1}", n, Mathematics.Factorial2(n));
            //Console.WriteLine("{0}! Factorial is = {1}", n, Mathematics.Factorial(n));
            //Console.WriteLine("{0} Sayinin asal carpanlarinin toplami = {1}", 180, Mathematics.AsalCarpanlarinCarpimi(180));
            ////Console.WriteLine("{0} Sayinin asal carpanlarinin toplami = {1}", 180, Mathematics.AsalCarpanlarinToplami(180));
            //Console.WriteLine("");
            string ifade = Convert.ToString(Console.ReadLine());
            //Mathematics d = new Mathematics();
            //int[] dizi = d.IfadiyeDiziyeCevir("1,2,3,4,5,6,78,8");
            StringExamples.SesliHarflerBelirleme(ifade);
            Console.WriteLine("***************************");
            //Mathematics.BinaryToDecimalConverter(ifade);
            Mathematics.DecimalToBinary(255);
            Console.WriteLine();
            Mathematics.BinaryToDecimalConverter("11111111");
            Console.ReadLine();
        }
    }
}
