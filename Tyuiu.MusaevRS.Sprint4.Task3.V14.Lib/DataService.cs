using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MusaevRS.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1; //строки
            int colums = array.Length / rows; //столбцы

            int MaxValue = 0;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < colums; j++)
                {
                    if (i == 3 && array[i,j] > MaxValue)
                    {
                        MaxValue = array[i, j];
                    }
                }
            return MaxValue;
        }
    }
}
