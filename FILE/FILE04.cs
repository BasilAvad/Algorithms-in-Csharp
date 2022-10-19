using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE
{
    public class FILE04
    {
        /// <summary>
        /// FileInfo clasin kullanarak bir dosyayla alakali olan detayli bilgileri erisebiliyoruz.
        /// </summary>
        public static void Anakod1()
        {
            string fileNeam = FilePath.FilePathFind("neams.txt");
            var fi = new FileInfo(fileNeam);
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.Name);
        }
    }
}
