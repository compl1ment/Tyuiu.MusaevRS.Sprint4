using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusaevRS.Sprint4.Task5.V26.Lib;

namespace Tyuiu.MusaevRS.Sprint4.Task5.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание №5                                                              *");
            Console.WriteLine("* Вариант №26                                                             *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Заменить положительные элементы на 1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5];
            int rows = 5;
            int colums = 5;
            Console.WriteLine("* Количество строк = " + rows);
            Console.WriteLine("* Количество столбцов = " + colums);
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    matrix[i, j] = rnd.Next(-4, 4);                                       
                }
            }           
            {
                for (int l = 0; l < rows;l++)
                {
                    for (int y = 0; y < colums; y++)
                    {
                        Console.Write(matrix[l, y] + "\t");                        
                    }
                    Console.WriteLine();
                   
                }           
            }
            Console.WriteLine("***************************************************************************");
            int[,] res = ds.Calculate(matrix);
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int k = 0; k < rows; k++)
            {
                for (int m = 0; m < rows; m++)
                {
                    Console.Write(res[k, m] + "\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();



   
        }
    }
}
