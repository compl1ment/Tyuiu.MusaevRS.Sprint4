using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusaevRS.Sprint4.Task7.V23.Lib;

namespace Tyuiu.MusaevRS.Sprint4.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание №7                                                              *");
            Console.WriteLine("* Вариант №23                                                             *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Преобразуйте строку вматрицу 4 на 3 и подсчитайте кол-во четных чисел   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");        
            int rows = 4;
            int colums = 3;
            string value = "678135972584";
            int[,] matrix = new int[rows, colums];
            Console.WriteLine("Строка = " + value);
            Console.WriteLine("***************************************************************************");
            {
            for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < colums; j++)
                    {
                        matrix[i, j] = int.Parse(value.Substring(i * colums + j, 1));
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }                              
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            int res = ds.Calculate(rows, colums, value);
            Console.WriteLine(res);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
