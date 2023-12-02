using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KulakovEE.Sprint6.Task1.V21.Lib;

namespace Tyuiu.KulakovEE.Sprint6.Task1.V21.Test
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
            wait[0] = 20.36;
            wait[1] = 15.42;
            wait[2] = 10.99;
            wait[3] = 7.43;
            wait[4] = 4.33;
            wait[5] = 1;
            wait[6] = 0;
            wait[7] = -8.87;
            wait[8] = -13.03;
            wait[9] = -16.53;
            wait[10] = -19.60;

            CollectionAssert.AreEqual(wait, res);
        }
    }
}