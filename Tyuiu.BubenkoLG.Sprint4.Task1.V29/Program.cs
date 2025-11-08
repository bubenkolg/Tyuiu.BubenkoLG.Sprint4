using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint4.Task1.V29.Lib;


namespace Tyuiu.BubenkoLG.Sprint4.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                                ");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры).                            ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #29                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный          ");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 9 подсчитать сумму           ");
            Console.WriteLine("* нечетных элементов массива.                                              ");

            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];

            for (int i = 0; i < len; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Массив: { 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8 }");

            int res = ds.Calculate(array);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}