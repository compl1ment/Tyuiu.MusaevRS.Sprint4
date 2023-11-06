﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusaevRS.Sprint4.Task4.V3.Lib;

namespace Tyuiu.MusaevRS.Sprint4.Task4.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание №4                                                              *");
            Console.WriteLine("* Вариант №3                                                              *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Найдите сумму нечетных элементов массива                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = new int[,] { { 7, 9, 7, 8, 6 }, { 4, 4, 4, 8, 6 }, { 7, 9, 6, 7, 6 }, { 7, 5, 4, 9, 8 }, { 9, 6, 4, 9, 8 } };
            Console.WriteLine("{ 7, 9, 7, 8, 6 }");
            Console.WriteLine("{ 4, 4, 4, 8, 6 }");
            Console.WriteLine("{ 7, 9, 6, 7, 6 }");
            Console.WriteLine("{ 7, 5, 4, 9, 8 }");
            Console.WriteLine("{ 9, 6, 4, 9, 8 }");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(matrix);
            Console.WriteLine(res);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
