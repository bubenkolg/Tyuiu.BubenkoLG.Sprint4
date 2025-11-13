using Microsoft.ApplicationInsights;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint4.Task4.V2.Lib;

namespace Tyuiu.BubenkoLG.Sprint4.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = { { 2, 2, 5, 5, 9 }, { 7, 3, 8, 8, 9 }, { 6, 7, 9, 3, 5 }, { 7, 5, 7, 7, 8 }, { 2, 2, 4, 7, 9 } };

            int[,] res = ds.Calculate(array);
            int[,] wait = { { 2, 2, 0, 0, 0 }, { 0, 0, 8, 8, 0 }, { 6, 0, 0, 0, 0 }, { 0, 0, 0, 0, 8 }, {2, 2, 4, 0, 0}};
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Assert.AreEqual(wait[i, j], res[i, j]);
                }
            }

        }
    }
}