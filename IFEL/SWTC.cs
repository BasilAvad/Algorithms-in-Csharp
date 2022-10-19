using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IFEL
{
    public class SWTC
    {
        public enum Colors { Kirmizi, Yesil, Mavi, Mor, Kahverengi }

        public static void Anakod()
        {

            Console.WriteLine("bir sayı gir");
            int t = Convert.ToInt32(Console.ReadLine());
            Colors r = (Colors)new Random().Next(0, t);
            switch (r)
            {
                case Colors.Kirmizi:
                    Console.WriteLine("kirmizi");
                    break;
                case Colors.Yesil:
                    Console.WriteLine("Yesil");
                    break;
                case Colors.Mavi:
                    Console.WriteLine("Mavi");
                    break;
                case Colors.Mor:
                    Console.WriteLine("Mor");
                    break;
                case Colors.Kahverengi:
                    Console.WriteLine("Kahvve");
                    break;
                default:
                    Console.WriteLine("Sikerim Senin Renklerin ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
