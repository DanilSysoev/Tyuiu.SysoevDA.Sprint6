using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SysoevDA.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            int lastRow = rows - 1;

            for (int i = 0; i < columns - 1; i++)
            {
                for (int j = 0; j < columns - i - 1; j++)
                {
                    if (matrix[lastRow, j] > matrix[lastRow, j + 1])
                    {
                        int temp = matrix[lastRow, j];
                        matrix[lastRow, j] = matrix[lastRow, j + 1];
                        matrix[lastRow, j + 1] = temp;
                    }
                }
            }

            return matrix;
        }

    }
}
