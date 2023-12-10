using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KulakovEE.Sprint6.Task4.V19.Lib;

namespace Tyuiu.KulakovEE.Sprint6.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 23.61;
            valueWaitArray[1] = 16.08;
            valueWaitArray[2] = 7.84;
            valueWaitArray[3] = 4.58;
            valueWaitArray[4] = 2.88;
            valueWaitArray[5] = 0.75;
            valueWaitArray[6] = -4.47;
            valueWaitArray[7] = -9.46;
            valueWaitArray[8] = -7.41;
            valueWaitArray[9] = -6.16;
            valueWaitArray[10] = -7.29;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}