using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint4.Task5.V23.Lib;

namespace Tyuiu.BubenkoLG.Sprint4.Task5.V23
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
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел).                     ");
            Console.WriteLine("* Задание #5                                                               ");
            Console.WriteLine("* Вариант #23                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный         ");
            Console.WriteLine("* случайными значениями с клавиатуры в диапазоне от -4 до 8. Заменить      ");
            Console.WriteLine("* отрицательные элементы массива на 0.                                     ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество строк в массиве:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве:");
            int colunms = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows, colunms];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colunms; j++)
                {
                    array[i,j] = rnd.Next(-4, 8);
                }
            }

            Console.WriteLine("* Массив:                                                                   ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colunms; j++)
                {
                    Console.WriteLine(array[i, j] + "\t");
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            int[,] res = ds.Calculate(array);

            Console.WriteLine("Итоговый массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colunms; j++)
                {
                    Console.WriteLine(res[i, j] + "\t");
                }
            }

            Console.ReadKey();
        }
    }
}