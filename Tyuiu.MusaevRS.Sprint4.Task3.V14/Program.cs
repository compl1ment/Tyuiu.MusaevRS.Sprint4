using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MusaevRS.Sprint4.Task3.V14.Lib;

namespace Tyuiu.MusaevRS.Sprint4.Task3.V14
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
            Console.WriteLine("* Задание №3                                                              *");
            Console.WriteLine("* Вариант №14                                                             *");
            Console.WriteLine("* Выполнил: Мусаев Руслан Шамхалович | ПКТб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Найдите максимальный элемент в четвертой строке массива                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] array = new int[5, 5] { { 3, 2, 3, 3, 5 },
                                           { 2, 3, 3, 7, 3 },
                                           { 7, 5, 2, 7, 3 },
                                           { 4, 2, 7, 5, 2 },
                                           { 3, 5, 4, 2, 6 } };

            Console.WriteLine("{ 3, 2, 3, 3, 5 }");
            Console.WriteLine("{ 2, 3, 3, 7, 3 }");
            Console.WriteLine("{ 7, 5, 2, 7, 3 }");
            Console.WriteLine("{ 4, 2, 7, 5, 2 }");
            Console.WriteLine("{ 3, 5, 4, 2, 6 }");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine(res);
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();

        }
    }
}
