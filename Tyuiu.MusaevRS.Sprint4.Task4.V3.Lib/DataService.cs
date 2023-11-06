using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MusaevRS.Sprint4.Task4.V3.Lib
{
    public class DataService
    {
        public int Calculate(int[,] matrix)
        {
            int s = 0;

            int rows = matrix.GetUpperBound(0) + 1; //строки
            int colums = matrix.Length / rows; //столбцы

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        s += matrix[i,j];
                    }
                }                  
            }
            return s;
                
        }
    }
}
