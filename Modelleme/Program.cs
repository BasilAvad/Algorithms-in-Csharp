using Modelleme.Banka;
using Modelleme.Cizim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Collections.Concurrent;


namespace Modelleme
{
    class Program
    {
        internal class MyCollection: IEnumerable
        {
            int[] data = { 1, 2, 3, 4 };

            public IEnumerator GetEnumerator()
            {
                foreach (int i in data)
                {
                    yield return i;
                }
            }
        }
        internal class MyGenCollection : IEnumerable<int>
        {
            int[] data = { 1, 2, 3, 4 };
            public IEnumerator<int> GetEnumerator()
            {
                foreach (int i in data)
                {
                    yield return i;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        static void Main(string[] args)
        {
            Array dizi = Array.CreateInstance(typeof(Int32), 3);
            dizi.SetValue(23, 0);
            dizi.SetValue(21, 1);
            dizi.SetValue(22, 2);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi.GetValue(i));
            }
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            
            //Arac arac = new Arac("Skoda","SuperB","Gri",2020);
            /* Arac arac = new Arac
             {
                 Motor = Motor.Dizel.ToString(),
                 Marka = "BMW",
                 Hacim = 1.8
             };
             arac.ToString();
             arac.Temizle();

             Arac seninAracin = new Arac
             {
                 Marka = "BMW",
                 Model = "efgrg",
                 Renk = Renk.Beyaz.ToString(),
                 Hacim = 1.2,

             };
             seninAracin.ToString();
             List<Arac> filo = new List<Arac>();

             filo.Add(new Arac
             {
                 Model = "SuperF",
                 Marka = "Skoda",
                 Renk = Renk.Mor.ToString(),
                 Yil=2021,
                 Hacim=1.1,
             }) ;
             filo.Add(new Arac
             {
                 Model = "Opel",
                 Marka = "Corsa",
                 Renk = Renk.Mor.ToString(),
                 Yil=2020,
                 Hacim=1.10,
             }) ;
             filo.Add(new Arac
             {
                 Model = "Bmw",
                 Marka = "23",
                 Renk = Renk.Mor.ToString(),
                 Yil=2030,
                 Hacim=1.9,
             }) ;
             foreach (Arac item in filo)
                 item.ToString();
             filo.RemoveAt(2);*/
            //var r = new Sekil();
            //r.pozisyon.X = 23;
            //r.pozisyon.Y = 55;
            //r.boyut.Genislik = 100;
            //r.boyut.Yukseklik = 100;

            //SekilCiz(r);
            //Console.ReadLine();
            //r.Tasi(new Pozisyon { X = 34, Y = 89 });
            //SekilCiz(r);
            //Sekil s = new Dikdortgen(90, 90, 80, 80);
            Console.WriteLine("----------------------------------");
            IBankaHesap bankaHesap = new MevduatHesapi();
            ITransfer aktif = new AktifHesap();
            aktif.Yatir(350);
            bankaHesap.Yatir(500);
            aktif.TransferYap(bankaHesap, 60);

            Console.WriteLine(aktif.ToString());
            Console.WriteLine(bankaHesap.ToString());
            Console.WriteLine("******************************");
            string f = "Hello";
            IEnumerator enumerator = f.GetEnumerator();
            foreach (char c in f)
            {
                Console.Write(c + ".");
            }











            Console.ReadLine();

        }

       

        public static void SekilCiz(Sekil sekil) =>
            sekil.Ciz();

    }
}
