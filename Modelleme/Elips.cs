using Modelleme.Cizim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Cizim
{
    public class Elips : Sekil
    {
        public override void Tasi(Pozisyon ypozisyon)
        {
            Console.WriteLine("Tasindi ");
            base.Tasi(ypozisyon);
        }

        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            boyut.Yukseklik = yukseklik;
            boyut.Genislik = genislik;
        }
    }
}
