using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint4.Task3.V26.Lib;


namespace Tyuiu.BubenkoLG.Sprint4.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();
            int[,] array = { { 4, 3, 2, 6, 2 }, { 5, 2, 2, 5, 6 }, { 2, 5, 4, 5, 6 }, { 4, 5, 2, 4, 6 }, { 6, 5, 4, 3, 6 } };


            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;


            Console.Title = "Спринт #4 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                                ");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод).                              ");
            Console.WriteLine("* Задание #3                                                               ");
            Console.WriteLine("* Вариант #26                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный         ");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 6. Найдите максимальный      ");
            Console.WriteLine("* элемент во второй строке массива.                                        ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Массив:                                                                   ");
            Console.WriteLine("{{4, 3, 2, 6, 2},                                                           ");
            Console.WriteLine(" {5, 2, 2, 5, 6},                                                           ");
            Console.WriteLine(" {2, 5, 4, 5, 6},                                                           ");
            Console.WriteLine(" {4, 5, 2, 4, 6},                                                           ");
            Console.WriteLine(" {6, 5, 4, 3, 6}}                                                           ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);

            Console.WriteLine("Максимальный элемент второй строки массива = " + res);

            Console.ReadKey();
        }
    }
}