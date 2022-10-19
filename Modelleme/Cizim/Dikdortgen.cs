using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Cizim
{
    public class Dikdortgen : Sekil
    {
        public Dikdortgen()
        {
            Console.WriteLine("Derived class -> contrustors");
        }

        public Dikdortgen(int genislik, int yukseklik, int y, int x) : base(genislik, yukseklik, y, x)
        {
            Console.WriteLine("Derived class -> contrustors - 4p");
        }

        public override void Ciz()=>
            Console.WriteLine($"Dikdortgen {pozisyon} - {boyut}");

        public override void Tasi(Pozisyon ypozisyon)
        {
            Console.WriteLine(" ");
            Console.Write("Dikdortgen ");
            base.Tasi(ypozisyon);
        }

        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            boyut.Genislik = genislik;
            boyut.Yukseklik = yukseklik;
        }
    }
}
