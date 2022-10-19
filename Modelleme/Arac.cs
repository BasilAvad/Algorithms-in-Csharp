using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelleme
{
    public class Arac:Tasit
    {
        #region Fields degiskenleri
        private string marka, model, renk;
        private int yil;
        #endregion
        #region Properties
        public string Marka { get => Marka1; set => Marka1 = value; }
        public string Model { get => model; set => model = value; }
        public string Renk { get => renk; set => renk = value; }
        public int Yil { get => yil; set => yil = value; }
        public string Marka1 { get => marka; set => marka = value; }

        #endregion
        #region Constructors
        public Arac()
        {

        }
        public Arac(string marka, string model, string renk, int yil)
        {
            Marka = marka;
            Yil = yil;
            Renk = renk;
            Model = model;
        }
        #endregion
        #region Methods
        public void Calistir()=>
            Console.WriteLine("Car is working");
        public void Durdur()=>
            Console.WriteLine("Car is'nt working");

        public override string ToString()
        {
            Console.WriteLine(new string('-',30));
            Console.WriteLine($"{Marka}");
            Console.WriteLine($"{Model}");
            Console.WriteLine($"{Renk}");
            Console.WriteLine($"{Yil}");
            Console.WriteLine($"{Motor}");
            Console.WriteLine($"{Hacim }");
            
            return " ";
        }
        #endregion

    }
}
