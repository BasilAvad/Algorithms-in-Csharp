using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme.Cizim
{
    public sealed class Pozisyon
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString() =>
            $"X : {X}, Y : {Y}";

    }
    public sealed class Boyut
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
        public override string ToString() =>
            $"Genislik {Genislik} " + $"Yukseklik: {Yukseklik}";

    }
    public abstract class Sekil
    {
        public Sekil()
        {
            Console.WriteLine("Base class");
        }
        public Sekil(int genislik, int yukseklik, int y, int x)
        {
            boyut = new Boyut
            {
                Genislik = genislik,
                Yukseklik = yukseklik,
            };
            pozisyon = new Pozisyon
            {
                X = x,
                Y = y
            };
        }
        public Pozisyon pozisyon { get; } = new Pozisyon();
        public Boyut boyut { get; } = new Boyut();

        public virtual void Ciz() =>
            Console.WriteLine($"Sekil {pozisyon} - {boyut}");

        public virtual void Tasi(Pozisyon ypozisyon)
        {
            pozisyon.X = ypozisyon.X;
            pozisyon.Y = ypozisyon.Y;
            Console.WriteLine($"Tasindi : {pozisyon}");
        }
        public abstract void YenidenBoyutlandir(int genislik, int gukseklik);

    }
}
