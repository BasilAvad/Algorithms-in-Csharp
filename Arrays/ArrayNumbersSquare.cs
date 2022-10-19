using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    public class ArrayNumbersSquare
    {
        public static int NumbersAndSquare(int A)
        {
            int[] number = new int[A];
            int[] square = new int[A];
            int n = number.GetLength(0);
            int f = 0;
            int d = square[0];
            for (int i = 0; i < n; i++)
            {
                f = f + 1;
                number[i] = new Random().Next(15, 30);
                square[i] = number[i] * number[i];
                d = square[i];
                Console.WriteLine("{0} - {1} Karesi = {2}", f, number[i], d);


            }
            Console.WriteLine("----------------");
            return d;
        }
    }
}
