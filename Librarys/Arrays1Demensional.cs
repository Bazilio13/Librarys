using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys
{
    public static class Arrays1Demensional
    {
        public static int[] FillArray(int[] array, int minNum = - 100, int maxNum = 100)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minNum, maxNum);
            }
            return array;
        }

        public static void PrintArrayOfInts(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write($"");
        }

        public static void PrintArrayOfDoubles(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.Write($"");
        }

        public static int GetMinNumber(int[] array)
        {
            int minNum;
            minNum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (minNum > array[i])
                {
                    minNum = array[i];
                }
            }
            return minNum;
        }

        public static int GetMaxNumber(int[] array)
        {
            int maxNum;
            maxNum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxNum < array[i])
                {
                    maxNum = array[i];
                }
            }
            return maxNum;
        }

        public static int GetIndexOfMinNum(int[] array)
        {
            int minNum;
            int minNumIndex = 0;
            minNum = array[minNumIndex];
            for (int i = 1; i < array.Length; i++)
            {
                if (minNum > array[i])
                {
                    minNum = array[i];
                    minNumIndex = i;
                }
            }
            return minNumIndex;
        }

        public static int GetIndexOfMaxNum(int[] array)
        {
            int maxNum;
            int maxNumIndex = 0;
            maxNum = array[maxNumIndex];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxNum < array[i])
                {
                    maxNum = array[i];
                    maxNumIndex = i;
                }
            }
            return maxNumIndex;
        }

        public static int SummOfOddIndex(int[] array)
        {
            int summOdd = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                summOdd += array[i];
            }
            return summOdd;
        }

        public static int[] ReversArray(int[] array)
        {
            int tmp;

            for (int i = 0; i < array.Length / 2; i++)
            {
                tmp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = tmp;
            }


            return array;
        }

        public static int CountOddNumbers(int[] array)
        {
            int numberOfOdd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    numberOfOdd++;
                }
            }


            return numberOfOdd;
        }

        public static int[] SwipeHalfs(int[] array)
        {
            int tmp;
            int i2;
            i2 = array.Length - 1;

            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                tmp = array[i];
                array[i] = array[i2];
                array[i2] = tmp;
                i2--;
            }

            return array;
        }

        public static int [] SortByBubble(int[] array)
        {
            //bool changes = true;

            //for (int i = 0; i < array.Length - 1; i++)
            //{


            //    if (array[i] > array[i+1])
            //    {
            //        tmp = array[i + 1];
            //        array[i + 1] = array[i];
            //        array[i] = tmp;
            //        changes = true;
            //    }

            //    if (i == array.Length - 2)
            //    {
            //        if (changes == false)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            changes = false;
            //            i = -1;
            //        }
            //    }

            //}

            int tmp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        tmp = array[j];
                        array[j] = array[i];
                        array[i] = tmp;
                    }
                }
            }

            return array;
        }

        public static int[] SortBySelect(int [] array)
        {
            int maxIndex;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int tmp;
                maxIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {

                    if (array[i] < array[j])
                    {
                        maxIndex = j;
                    }

                }
                if (array[maxIndex] > array[i])
                {
                    tmp = array[maxIndex];
                    array[maxIndex] = array[i];
                    array[i] = tmp;
                }
            }

            return array;
        }
    }
}
