using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KulakovEE.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] temp = new int[5];
            for (int i = 0; i < 5; i++)
            {
                temp[i] = matrix[i, 4];
            }
            Array.Sort(temp);
            for (int i = 0; i < 5; i++)
            {
                matrix[i, 4] = temp[i];
            }
            return matrix;
        }
    }
}