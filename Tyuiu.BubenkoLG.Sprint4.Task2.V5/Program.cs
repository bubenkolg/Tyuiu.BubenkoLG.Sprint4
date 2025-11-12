using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint4.Task2.V5.Lib;


namespace Tyuiu.BubenkoLG.Sprint4.Task2.V5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                                ");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел).                    ");
            Console.WriteLine("* Задание #2                                                               ");
            Console.WriteLine("* Вариант #5                                                               ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный          ");
            Console.WriteLine("* случайными в диапазоне от 3 до 9 подсчитать произведение четных          ");
            Console.WriteLine("* элементов массива.                                                       ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];

            for (int i = 0; i < len; i++)
            {
                array[i] = rnd.Next(3, 9);
            }

            Console.WriteLine("* Массив:                                                                  ");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);

            Console.WriteLine("Произведение чётных элементов массива = " + res);

            Console.ReadKey();
        }
    }
}