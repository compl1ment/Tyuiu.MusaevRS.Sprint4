using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { -2, 5, -8, 7 }, { -6, -7, 2, -5 }, { 6, 4, -8, 2 }, { 2, -7, 6, -3 } };
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] > 0)
                        count++;
            Console.WriteLine(count);
            Console.ReadKey();
        }
       
    }
}
