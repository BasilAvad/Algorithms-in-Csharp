using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFEL
{
   public class Ax2_BX_C
    {
        public static void KokBul(double a,double b,double c)
        {
            
            double delta = 0;
            delta = (Math.Pow(b, 2) - 4 * a * c);
            Console.WriteLine(" Delta = {0}", delta);
            double deltaSqrt = Math.Sqrt(delta);
            if (delta>0)
            {
                double x1 = (-b + deltaSqrt) / (2 * a);
                double x2 = (-b - deltaSqrt) / (2 * a);
                Console.WriteLine(" Delta > 0 için X1= {0} X2={1}", x1,x2);
            }
            if (delta==0)
            {
                double x1 = (-b) / (2 * a);
                Console.WriteLine("X1=X2 = {0}",x1);
            }
            if (delta<0)
            {
                Console.WriteLine("Denklemin Reel Çözümü yok");
            }
           
        }
    }
}
