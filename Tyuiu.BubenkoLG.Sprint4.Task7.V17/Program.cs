using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint4.Task7.V17.Lib;

namespace Tyuiu.BubenkoLG.Sprint4.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                                ");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                 ");
            Console.WriteLine("* Задание #7                                                               ");
            Console.WriteLine("* Вариант #17                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"753159864\". Преобразуйте ее         ");
            Console.WriteLine("* в матрицу 3 на 3 и подсчитайте количество четных чисел                   ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Массив:                                                                  ");

            string str = "753159864";
            int rows = 3;
            int columns = 3;
            int[,] array = new int[rows, columns];

            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows,columns,str);

            Console.WriteLine("Количество четных чисел = " + res);
            Console.ReadKey();
        }
    }
}