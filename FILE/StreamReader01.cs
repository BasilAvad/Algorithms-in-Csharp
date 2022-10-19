using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE
{
    public class StreamReader01
    {
        public static void streamReader()
        {
            try
            {
                string fileNeam = FilePath.FilePathFind("nums.txt");
                using (StreamReader sr = new StreamReader(""))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine(fileNeam);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }
    }
}
