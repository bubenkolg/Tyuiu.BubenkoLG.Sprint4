using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint4.Task0.V12.Lib;


namespace Tyuiu.BubenkoLG.Sprint4.Task0.V12
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                                ");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод).                             ");
            Console.WriteLine("* Задание #0                                                               ");
            Console.WriteLine("* Вариант #12                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный          ");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение    ");
            Console.WriteLine("* четных элементов массива.                                                ");

            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Массив: { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 }");

            int res = ds.GetMultEvenArrEl(array);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}