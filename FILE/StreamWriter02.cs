using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE
{
    public class StreamWriter02
    {
        /// <summary>
        /// Klavyadan girilen isimleri bir dosyaya yazdık.
        /// </summary>
        public static void Anakod()
        {
            string neam = "";
            string fileNeam = FilePath.FilePathFind("neams.txt");
            try
            {
                FileStream fs = new FileStream(fileNeam,
                    FileMode.Append,
                    FileAccess.Write
                    , FileShare.None);
                while (neam != "Cikis")
                {

                    Console.WriteLine("\n Dosya kaydet uzere bir isim giriniz : ");
                    neam = Console.ReadLine();
                    if (neam != "Cikis")
                    {
                        if (fs.CanWrite)
                        {
                            byte[] print = Encoding.UTF8.GetBytes(neam);
                            fs.Write(print, 0, print.Length);
                            fs.WriteByte(13);
                        }
                        else
                        {
                            Console.WriteLine("Yazma yetkisi yok ");
                        }
                    }
                }
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(fileNeam);
        }
    }
}
