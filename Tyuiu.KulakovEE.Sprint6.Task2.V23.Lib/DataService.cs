using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KulakovEE.Sprint6.Task2.V23.Lib
{
    public class DataService : ISprint6Task2V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            {
                double[] func = new double[stopValue - startValue + 1];
                for (int i = 0, x = startValue; x <= stopValue; i++, x++)
                {
                    if ((2 * x - 2) != 0)
                    {
                        func[i] = Math.Round(4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2), 2);
                    }
                    else
                    {
                        func[i] = 0;
                    }

                }


                return func;
            }
        }
    }
}