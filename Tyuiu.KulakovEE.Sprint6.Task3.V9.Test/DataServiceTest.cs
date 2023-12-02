using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KulakovEE.Sprint6.Task3.V9.Lib;

namespace Tyuiu.KulakovEE.Sprint6.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = { { -14,  25,  26,  18,  17 },
                              { 28,  10,   6,  -2,   4 },
                              { 30,  25,  -3,  11, -10 },
                              { 11,  32,  -5, -20,  25 },
                              { 2, -18,  11,   8, -20} };

            int[,] res = ds.Calculate(matrix);
            int[,] wait = { { -14, 25, 26, 18, -20 },
                            { 28, 10,  6, -2, -10 },
                            { 30, 25, -3, 11, 4},
                            { 11, 32, -5, -20, 17 },
                            { 2, -18, 11, 8, 25 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}