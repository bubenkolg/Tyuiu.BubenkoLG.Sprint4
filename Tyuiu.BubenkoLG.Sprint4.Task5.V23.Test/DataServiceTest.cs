using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint4.Task5.V23.Lib;

namespace Tyuiu.BubenkoLG.Sprint4.Task5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = { { 2, 2, -1, 5, 9 }, { 7, -5, 8, 8, 9 }, { 6, 7, 9, 3, 5 }, { 7, -4, 7, -1, 8 }, { 2, 2, 4, 7, 9 } };

            int[,] res = ds.Calculate(array);
            int[,] wait = { { 2, 2, 0, 5, 9 }, { 7, 0, 8, 8, 9 }, { 6, 7, 9, 3, 5 }, { 7, 0, 7, 0, 8 }, {2, 2, 4, 7, 9}};
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    Assert.AreEqual(wait[i, j], res[i, j]);
                }
            }
        }
    }
}