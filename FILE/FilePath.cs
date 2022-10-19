using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE
{
    public class FilePath
    {
        public static string FilePathFind(string fileneam)
        {
            string[] path = Directory.GetCurrentDirectory().Split('\\');
            string faylePath = "";
            for (int i = 0; i < path.Length; i++)
                faylePath += path[i] + "\\";
            faylePath += fileneam;
            return faylePath;
        }
    }
}
