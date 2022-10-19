using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD2
{
    public class StringExamples
    {
        /// <summary>
        /// Desen oluşturucu {Pattern maker}
        /// </summary>
        /// <param name="c">Karakter tanımı {Character definition}</param>
        /// <param name="n">Tekrar sayısı {The number of repetitions}</param>
        public static void Pattern1(char c='S',int n=10)
        {
            for (int j = 0; j <=n; j++)
            {
                Console.WriteLine("{0,20}", new string(c, j));

            }
        }
        /// <summary>
        /// Desen oluşturucu {Pattern maker second example}
        /// </summary>
        /// <param name="c">Karakter tanımı {Character definition}</param>
        /// <param name="n">Tekrar sayısı {The number of repetitions}</param>
        public static void Pattern2(char c='!',int n=10)
        {
            for (int j = n; j >=0; j--)
            {
                Console.WriteLine("{0}", new string(c, j));

            }
        }
        /// <summary>
        /// Karakter Seti Metodu
        /// </summary>
        /// <param name="StartIndex">Baslangic Degeri</param>
        /// <param name="EndingIndex">Bitis Degeri</param>
        /// <param name="Linecharacternumber">Mesafe </param>
        public static void Pattern3(int StartIndex=65,int EndingIndex  =90,int Linecharacternumber=5)
        {
            for (int j = StartIndex; j <=EndingIndex; j++)
            {
                Console.Write("{0,5}",(char)j);
                if (j%Linecharacternumber==0)
                {
                    Console.WriteLine();
                }

            }
        }
        /// <summary>
        /// Klavyeden girilen ifadenin sesli harflerini sayısını belirleyen program.
        /// </summary>
        /// <param name="ifade">Girilen ifade</param>
        /// <returns>Sesli harflarin sayisi</returns>
        public static int SesliHarflerBelirleme(string ifade)
        {
            int sesliharf = 0;
            for (int i = 0; i < ifade.Length; i++)
            {
                if (ifade[i]==  'a'|| 
                    ifade[i] == 'A'|| 
                    ifade[i] == 'e'||
                    ifade[i] == 'E'||
                    ifade[i] == 'ı'|| 
                    ifade[i] == 'I'|| 
                    ifade[i] == 'i'|| 
                    ifade[i] == 'İ'|| 
                    ifade[i] == 'ü'|| 
                    ifade[i] == 'Ü'||
                    ifade[i] == 'u'||
                    ifade[i] == 'U'||
                    ifade[i] == 'o'||
                    ifade[i] == 'O'||
                    ifade[i] == 'ö'||
                    ifade[i] == 'Ö')
                {
                    sesliharf++;
                }
            }
            
            Console.WriteLine("{0} ifadesinde {1} sesli harf var",ifade,sesliharf);
            return sesliharf;
           
        }
       
    }
}
