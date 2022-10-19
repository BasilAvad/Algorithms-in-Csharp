using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMD1
{
    public   class Circle
    {
        public static double Cemper_Cevre_Bul(double r)
        {
            r = 2 * Math.PI * r;
            return r;
        }
        public const double pi = Math.PI;
        /// <summary>
        /// Dairenin Alanı hesapla 
        /// </summary>
        /// <param name="r">Yari Çap</param>
        /// <returns> Alan Değeridir</returns>

        public static double Daire_Alanı_Bul(double r)
        {
            r = pi * Math.Pow(r, 2);
            return r;
        }
        public static double Daire_Alanı_Bul(double r, double Alfa)
        {
            r = pi * Math.Pow(r, 2)*Alfa/360;
            return r;
        }

    }
}
