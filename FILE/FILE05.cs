using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE
{
    public class FILE05
    {
        /// <summary>
        /// Dosya kopyalama islemi gerceklestirir.
        /// </summary>
        /// <param name="kaynak">Kaynak dosya yolu</param>
        /// <param name="hedef">Hedef dosya yolu</param>
        public static void FileCopy(string kaynak, string hedef)
        {
            try
            {

                FileInfo fi = new FileInfo(kaynak);
                fi.CopyTo(hedef);
                Console.WriteLine(" {0} kaynakli dosya {1} kopyalandi. ", kaynak, hedef);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Verilen parametre bilgisine bagli olarak ilgili dosyaya
        /// kalici olarak siler.
        /// </summary>
        /// <param name="kaynak">Kaynak dosya yolu</param>
        public static void FileDelete(string kaynak)
        {
            try
            {

                FileInfo fi = new FileInfo(kaynak);
                fi.Delete();
                Console.WriteLine("Dosya silindi.");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}");
            }
        }
    }
}
