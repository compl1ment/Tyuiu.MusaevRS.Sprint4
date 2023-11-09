using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] { "Программирование", "Код", "Функция", "Класс", "Массив", "Переменная", "Структура" };
            int count = words.Count(w => w.Length > 5);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
