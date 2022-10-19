using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE
{
    class Program
    {


        static void Main(string[] args)
        {

            //string hedef = FilePath.FilePathFind("neams.txt");
            //Console.WriteLine(hedef);
            //FILE05.FileDelete(hedef);
            Kisi k = new Kisi("Basil", 23);
            Console.WriteLine(k.Adi +" : "+k.Yas);
            string s = "Basil Ahmed Avad";
            Console.WriteLine($"{s.KelimeSayisi()}");
            Console.ReadLine();
        }
    }
    /// <summary>
    /// ctor Yapilandirici sinif ornegi
    /// </summary>
    public class Kisi
    {
        public Kisi()
        {

        }
        public Kisi(string adi)
        {
            Adi = adi;
        }
        public Kisi(string adi,int yas)
        {
            Adi = adi;
            Yas = yas;
        }
        
        public string Adi { get ; set ; }
        public int Yas { get ; set ; }
    }
    public static class StringExtension
    {
        public static int KelimeSayisi(this string s) =>
            s.Split().Length;
    }
    
}
