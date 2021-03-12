using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys
{
    public static class Arrays1Demensional
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
                        "\nРАЗДЕЛ \"ОДНОМЕРНЫЕ МАССИВЫ\"" +
                        "\n1. Найти минимальный элемент массива" +
                        "\n2. Найти максимальный элемент массива" +
                        "\n3. Найти индекс минимального элемента массива" +
                        "\n4. Найти индекс максимального элемента массива" +
                        "\n5. Посчитать сумму элементов массива с нечетными индексами" +
                        "\n6. Сделать реверс массива (массив в обратном направлении)" +
                        "\n7. Посчитать количество нечетных элементов массива" +
                        "\n8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312." +
                        "\n9. Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором (Select) или вставками (Insert))" +
                        "\n10. Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :  пузырьком(Bubble), выбором (Select) или вставками (Insert))");
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
                        a = Convert.ToInt32(Console.ReadLine());
                        int[] array;
                        array = FillArray(new int[a]);
                        PrintArrayOfInts(array);
                        Console.WriteLine($"" +
                            $"\nМинимальный элемент массива: {GetMinNumber(array)}");
                        break;
                    case "2":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a]);
                        PrintArrayOfInts(array);
                        Console.WriteLine($"" +
                            $"\nМаксимальный элемент массива: {GetMaxNumber(array)}");
                        break;
                    case "3":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a]);
                        PrintArrayOfInts(array);
                        Console.WriteLine($"" +
                            $"\nИндекс минимального элемента массива: {GetIndexOfMinNum(array)}");
                        break;
                    case "4":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a]);
                        PrintArrayOfInts(array);
                        Console.WriteLine($"" +
                            $"\nИндекс максимального элемента массива: {GetIndexOfMaxNum(array)}");
                        break;
                    case "5":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a]);
                        PrintArrayOfInts(array);
                        Console.WriteLine($"" +
                            $"\nСумма нечетных элементов массива: {SummNumbersWithOddIndex(array)}");
                        break;
                    case "6":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a]);
                        PrintArrayOfInts(array);
                        Console.WriteLine($"" +
                            $"\nРеверс массива:");
                        PrintArrayOfInts(ReversArray(array));
                        break;
                    case "7":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a]);
                        PrintArrayOfInts(array);
                        Console.WriteLine($"" +
                            $"\nКолличество нечетных элементов: {CountOddNumbers(array)}");
                        break;
                    case "8":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a]);
                        PrintArrayOfInts(array);
                        Console.WriteLine($"" +
                            $"\nМассив с поменяными местами половинами:");
                        PrintArrayOfInts(SwipeHalfs(array));
                        break;
                    case "9":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a]);
                        PrintArrayOfInts(array);
                        Console.WriteLine($"" +
                            $"\nСортировка по возрастанию:");
                        PrintArrayOfInts(SortByBubble(array));
                        break;
                    case "10":
                        Console.WriteLine("Введите размер массива");
                        a = Convert.ToInt32(Console.ReadLine());
                        array = FillArray(new int[a]);
                        PrintArrayOfInts(array);
                        Console.WriteLine($"" +
                            $"\nСортировка по убыванию:");
                        PrintArrayOfInts(SortBySelect(array));
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
            if (array.Length < 1)
            {
                throw new Exception("Массив пуст");
            }

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
            if (array.Length < 1)
            {
                throw new Exception("Массив пуст");
            }
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
            if (array.Length < 1)
            {
                throw new Exception("Массив пуст");
            }
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
            if (array.Length < 1)
            {
                throw new Exception("Массив пуст");
            }
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

        public static int SummNumbersWithOddIndex(int[] array)
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
                if (Math.Abs(array[i]) % 2 == 1)
                {
                    numberOfOdd++;
                }
            }


            return numberOfOdd;
        }

        public static int[] SwipeHalfs(int[] array)
        {
            //if (array.Length < 1)
            //{
            //    throw new Exception("Массив пуст");
            //}
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

                    if (array[maxIndex] < array[j])
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
