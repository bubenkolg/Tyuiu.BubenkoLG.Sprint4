using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.BubenkoLG.Sprint4.Task7.V17.Lib
{
    public class DataService : ISprint4Task7V17
    {
        public int Calculate(int rows, int columns, string value)
        {
            int count = 0;
            int[,] nums = new int[rows, columns];

            for (int k = 0; k < value.Length; k++)
            { 
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        nums[i, j] = int.Parse(value.Substring(i * columns + j, 1));
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (nums[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}