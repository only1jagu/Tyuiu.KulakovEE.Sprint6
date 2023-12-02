using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KulakovEE.Sprint6.Task2.V23.Lib;

namespace Tyuiu.KulakovEE.Sprint6.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5, stop = 5;
            double[] res = ds.GetMassFunction(start, stop);
            double[] wait = new double[stop - start + 1];
            wait[0] = 13.81;
            wait[1] = 11.87;
            wait[2] = 9.87;
            wait[3] = 7.74;
            wait[4] = 5.36;
            wait[5] = 2.50;
            wait[6] = 0;
            wait[7] = 0.79;
            wait[8] = -1.75;
            wait[9] = -3.78;
            wait[10] =-5.71;

            CollectionAssert.AreEqual(wait, res);
        }
    }
}