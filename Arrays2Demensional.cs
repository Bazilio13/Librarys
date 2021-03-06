using System;

namespace Arr2D
{
    public class Arrays2Demrnsioned
    {
        public static int FindMinNumber(int[][] array)
        {
            int minNumber = array[0, 0];
            for (int i = 0; i < array.GetLength[0], i++)
            {
                for (int j = 1; j < array.GetLength[1], j++)
                    if (array[i, j] < minNumber)
                    {
                        minNumber = array[i, j]
                    }
            }
            return minNumber;
        }
    }
}
