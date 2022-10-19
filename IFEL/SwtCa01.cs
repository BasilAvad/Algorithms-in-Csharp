using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFEL
{
    public class SwtCa01
    {
        public static void Anakod()
        {
            Random rnd = new Random();
            int SWitcCase = rnd.Next(1, 7);
            switch (SWitcCase)
            {
                case 1:
                    Console.WriteLine(" Durum 1");
                    break;
                case 2:
                case 3:
                    Console.WriteLine($" caae {SWitcCase}");
                    break;

                default:

                    Console.WriteLine(" Durum dışında ");
                    break;
            }
        }
    }
}
