using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys
{
    public static class Arrays2Demrnsioned
    {
        public static int[,] FillArray(int[,] array, int minNum = -100, int maxNum = 100)
        {
            Random random = new Random();
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minNum, maxNum);
                }
            }
            return array;
        }

        public static void Print(int [,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine("");
            }
        }
        public static int FindMinNumber(int[,] array)
        {
            int minNumber = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] < minNumber)
                    {
                        minNumber = array[i, j];
                    }
            }
            return minNumber;
        }

        public static int FindMaxNumber(int[,] array)
        {
            int maxNumber = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] > maxNumber)
                    {
                        maxNumber = array[i, j];
                    }
            }
            return maxNumber;
        }

        public static int[] FindIndexOfMaxNumber(int[,] array)
        {
            int maxNumber = array[0, 0];
            int [] indexOfMaxNum = { 0, 0};
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] > maxNumber)
                    {
                        maxNumber = array[i, j];
                        indexOfMaxNum[0] = i;
                        indexOfMaxNum[1] = j;
                    }
            }
            return indexOfMaxNum;
        }
        public static int[] FindIndexOfMinNumber(int[,] array)
        {
            int maxNumber = array[0, 0];
            int[] indexOfMaxNum = { 0, 0 };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] < maxNumber)
                    {
                        maxNumber = array[i, j];
                        indexOfMaxNum[0] = i;
                        indexOfMaxNum[1] = j;
                    }
            }
            return indexOfMaxNum;
        }
        public static int CountBiggerNummbers (int [,] array)
        {
            int countOfBiggerNumber = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                   if (j - 1 >= 0)
                    {
                    
                        if (array[i, j - 1] >= array[i, j])
                        {
                            continue;
                        }
                    }
                   if (j + 1 < array.GetLength(1))
                    {
                    
                        if (array[i, j + 1] >= array[i, j])
                        {
                            continue;
                        }

                    }
                    if (i - 1 >= 0)
                    {
                        if (array[i - 1, j] >= array[i, j])
                        {
                            continue;
                        }
                    }
                    if (i + 1 < array.GetLength(0))
                    {
                        if (array[i + 1, j] >= array[i, j])
                        {
                            continue;
                        }
                    }
                    countOfBiggerNumber++;
                }
            }

            return countOfBiggerNumber; 
        }

        public static int [,] TransposeArray (int [,] array)
        {
            int[,] transposedArray = new int[array.GetLength(1), array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    transposedArray[j, i] = array[i, j];
                }
            }
            return transposedArray;
        }
    }
}
