using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint4.Task6.V3.Lib;

namespace Tyuiu.BubenkoLG.Sprint4.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                                ");
            Console.WriteLine("* Тема: Класс Array.                                                       ");
            Console.WriteLine("* Задание #6                                                               ");
            Console.WriteLine("* Вариант #3                                                               ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дан строковый массив данных [\"Январь\", \"Февраль\", \"Март\",          ");
            Console.WriteLine("* \"Апрель\", \"Май\", \"Июнь\", \"Июль\", \"Август\", \"Сентябрь\",       ");
            Console.WriteLine("* \"Октябрь\", \"Ноябрь\",\"Декабрь\"] используя класс Array подсчитайте   ");
            Console.WriteLine("* количество элементов, длина которых меньше 6.                            ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Массив:                                                                  ");

            string[] array = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            Console.WriteLine("* {Январь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь        ");
            Console.WriteLine("* Октябрь, Ноябрь, Декабрь}                                                ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Количество элементов, длина которых меньше 6 = " + res);
            Console.ReadKey();
        }
    }
}