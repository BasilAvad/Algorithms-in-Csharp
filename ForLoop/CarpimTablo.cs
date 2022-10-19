using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    public class CarpimTablo
    {
        public static double Carpım(double A,double B)
        {

            for (int i = 0; i <= A; i++)
            {
                for (int j = 0; j <= B; j++)
                {
                    Console.WriteLine("{0,5} * {1,5} = {2,5}", i, j, i * j);
                }
                Console.WriteLine("\n\n----------------\n\n");   
            }
            return A;
        }
    }
}
