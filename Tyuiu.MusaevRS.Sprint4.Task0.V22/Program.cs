using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusaevRS.Sprint4.Task0.V22.Lib;

namespace Tyuiu.MusaevRS.Sprint4.Task0.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил Мусаев Р.Ш. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание №0                                                              *");
            Console.WriteLine("* Вариант №22                                                             *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Подсчитать сумму нечетных элементов массива                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* {9, 5, 7, 4, 5, 3, 7, 8, 9, 1}                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[] array;
            array = new int[10] { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int res = ds.GetSumOddArrEl(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
