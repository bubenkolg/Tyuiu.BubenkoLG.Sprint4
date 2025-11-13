using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint4.Task4.V2.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.BubenkoLG.Sprint4.Task4.V2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                                ");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры).                             ");
            Console.WriteLine("* Задание #4                                                               ");
            Console.WriteLine("* Вариант #2                                                               ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный         ");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9. Заменить нечетные         ");
            Console.WriteLine("* элементы массива на 0.                                                   ");

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
                    Console.WriteLine($"Введите {i},{j} элемент массива:");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("* Массив:                                                                   ");
            Console.WriteLine("{{4, 3, 2, 6, 2},                                                           ");
            Console.WriteLine(" {5, 2, 2, 5, 6},                                                           ");
            Console.WriteLine(" {2, 5, 4, 5, 6},                                                           ");
            Console.WriteLine(" {4, 5, 2, 4, 6},                                                           ");
            Console.WriteLine(" {6, 5, 4, 3, 6}}                                                           ");

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