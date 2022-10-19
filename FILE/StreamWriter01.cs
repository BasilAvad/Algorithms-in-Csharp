using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE
{
    public class StreamWriter01
    {
        public static void streamWriter()
        {
            try
            {
                string[] rot = Directory.GetCurrentDirectory().Split('\\');
                string fayleRot = "";
                for (int i = 0; i < fayleRot.Length-3; i++)
                {
                    fayleRot += rot[i] + "\\";
                    
                }
                fayleRot += "nums.txt";
                string[] neams = new string[] { "zara", "dfd", "basil", "avad" };
                using (StreamWriter sw = new StreamWriter(fayleRot))
                {
                    foreach (var s in neams)
                    {
                        sw.WriteLine(s);
                    }
                    Console.WriteLine("\n neams basarlı bir sekilde olusturuldu.");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
