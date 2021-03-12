using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys
{
    public static class Arrays2Demensional
    {
        public static string ShowMenu()
        {
            string navigation = "";
            bool showNav = true;
            while (navigation != "exit" || navigation != "menu")
            {
                if (showNav)
                {
                    Console.WriteLine("---------------------------------------------------------------" +
                        "\nРАЗДЕЛ \"ДВУМЕРНЫЕ МАССИВЫ\"" +
                        "\n1. Найти минимальный элемент массива" +
                        "\n2. Найти максимальный элемент массива" +
                        "\n3. Найти индекс минимального элемента массива" +
                        "\n4. Найти индекс максимального элемента массива" +
                        "\n5. Найти количество элементов массива, которые больше всех своих соседей одновременно" +
                        "\n6. Отразите массив относительно его главной диагонали");
                }
                Console.WriteLine("" +
                    "\nДля выбора задачи введите ее номер" +
                    "\nДля выхода введите exit" +
                    "\nДля выхода в основное меню введите back" +
                    "\nДля повтора меню введите menu");
                showNav = false;
                navigation = Console.ReadLine();
                switch (navigation)
                {
                    case "1":
                        Console.WriteLine("Введите размер массива");
                        int a;
                        int b;
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        int[,] array;
                        array = FillArray(new int[a, b]);
                        Print(array);
                        Console.WriteLine($"" +
                            $"\nМинимальный элемент массива: {GetMinNumber(array)}");
                        break;
                    case "2":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a, b]);
                        Print(array);
                        Console.WriteLine($"" +
                            $"\nМинимальный элемент массива: {GetMaxNumber(array)}");
                        break;
                    case "3":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a, b]);
                        Print(array);
                        Console.WriteLine($"" +
                            $"\nИндекс минимального элемента массива:");
                        Arrays1Demensional.PrintArrayOfInts(FindIndexOfMinNumber(array));
                        break;
                    case "4":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a, b]);
                        Print(array);
                        Console.WriteLine($"" +
                            $"\nИндекс максимального элемента массива:");
                        Arrays1Demensional.PrintArrayOfInts(FindIndexOfMaxNumber(array));
                        break;
                    case "5":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a, b]);
                        Print(array);
                        Console.WriteLine($"" +
                            $"\nКоличество элементов, которые больше своих соседей: {CountBiggerNummbers(array)}");
                        break;
                    case "6":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a, b]);
                        Print(array);
                        Console.WriteLine($"" +
                            $"\nОтраженный массив:");
                        Arrays2Demensional.Print(TransposeArray(array));
                        break;
                    case "exit":
                        return "exit";
                    case "back":
                        return "";
                    case "menu":
                        showNav = true;
                        break;
                    default:
                        Console.WriteLine("Введена неизвестная команда");
                        continue;
                }
            }
            return "";
        }
        public static int[,] FillArray(int[,] array, int minNum = -100, int maxNum = 100)
        {
            if (array.GetLength(0) < 1|| array.GetLength(1) < 1)
            {
                throw new Exception("Массив пуст");
            }

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
            if (array.GetLength(0) < 1 || array.GetLength(1) < 1)
            {
                throw new Exception("Массив пуст");
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine("");
            }
        }
        public static int GetMinNumber(int[,] array)
        {
            if (array.GetLength(0) < 1 || array.GetLength(1) < 1)
            {
                throw new Exception("Массив пуст");
            }
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

        public static int GetMaxNumber(int[,] array)
        {
            if (array.GetLength(0) < 1 || array.GetLength(1) < 1)
            {
                throw new Exception("Массив пуст");
            }
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
            if (array.GetLength(0) < 1 || array.GetLength(1) < 1)
            {
                throw new Exception("Массив пуст");
            }
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
            if (array.GetLength(0) < 1 || array.GetLength(1) < 1)
            {
                throw new Exception("Массив пуст");
            }
            int minNumber = array[0, 0];
            int[] indexOfMinNum = { 0, 0 };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] < minNumber)
                    {
                        minNumber = array[i, j];
                        indexOfMinNum[0] = i;
                        indexOfMinNum[1] = j;
                    }
            }
            return indexOfMinNum;
        }
        public static int CountBiggerNummbers (int [,] array)
        {
            int countOfBiggerNumber = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i == 0 || array[i-1, j] < array[i,j])
                        && (i == array.GetLength(0) - 1 || array[i + 1, j] < array[i, j])
                        && (j == 0 || array[i, j - 1] < array[i, j])
                        && (j == array.GetLength(1) - 1 || array[i, j + 1] < array[i, j]))
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
