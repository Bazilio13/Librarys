using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys
{
    public static class Cycles
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
                        "\nРАЗДЕЛ \"ЦИКЛЫ\"" +
                        "\n1. Пользователь вводит 2 числа (A и B). Возвести число A в степень B." +
                        "\n2. Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A." +
                        "\n3. Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A." +
                        "\n4. Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A." +
                        "\n5. Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A)." +
                        "\n6. Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1." +
                        "\n7. Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида." +
                        "\n8. Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления." +
                        "\n9. Пользователь вводит 1 число. Найти количество нечетных цифр этого числа." +
                        "\n10. Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321." +
                        "\n11. Пользователь вводит целое положительное  число (N). Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных." +
                        "\n12. Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.");
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
                        Console.WriteLine("Введите числа А и В");
                        int a;
                        int b;
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a} ^ {b} = {RaiseToAPower(a, b)}");                            
                        break;
                    case "2":
                        Console.WriteLine("Введите число");
                        a = Convert.ToInt32(Console.ReadLine());
                        Arrays1Demensional.PrintArrayOfInts(GetDivisibleNumbers(a));
                        break;
                    case "3":
                        Console.WriteLine("Введите число");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Количество чисел, квадрат которых меньше А: {CountNumbersWhichSquearsLessA(a)}");
                        break;
                    case "4":
                        Console.WriteLine("Введите число");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Наибольший делитель: {GetMaxDivisor(a)}");
                        break;
                    case "5":
                        Console.WriteLine("Введите числа А и В (границы диапазона)");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Сумма всех чисел из диапазона от {a} до {b}, которые делятся без остатка на 7 = {GetSumOfDivisors(a, b)}");
                        break;
                    case "6":
                        Console.WriteLine("Введите число N");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a}-ое число Фибоначчи = {GetFibonacciNumber(a)}");
                        break;
                    case "7":
                        Console.WriteLine("Введите числа А и В");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Наибольший общий делить = {GetMaxCommonDivisor(a, b)}");
                        break;
                    case "8":
                        Console.WriteLine("Введите число");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Число {a} является кубом числа {GetCubeRoot(a)}");
                        break;
                    case "9":
                        Console.WriteLine("Введите число");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Количество нечетных цифр = {CountOddNumbers(a)}");
                        break;
                    case "10":
                        Console.WriteLine("Введите число");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Реверс числа: {ReversNumber(a)}");
                        break;
                    case "11":
                        Console.WriteLine("Введите число");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Числа в диапазоне от 1 до {a}, сумма четных цифр которых больше суммы нечетных:");
                        Arrays1Demensional.PrintArrayOfInts(GetNumbersWithSumOfEvenMoreThenSumOfOdd(a));
                        break;
                    case "12":
                        Console.WriteLine("Введите числа А и В");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        bool check = CheckMatchOfNumbers(a, b);
                        string result = "НЕТ";
                        if (check)
                        {
                            result = "ДА";
                        }
                        Console.WriteLine($"Есть ли совпадающие цифры? {result}");
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
        public static double RaiseToAPower(int num, int degree)
        {
            double result = 1;

            if (num == 0 && degree < 0)
            {
                throw new Exception("0 нельзя возводить в отрицательную степень");
            }

            if (degree >= 0)
            {
                for (int i = 0; i < degree; i++)
                {
                    result *= num;
                }
            }
            else
            {
                for (int i = 0; i > degree; i--)
                {
                    result *= (double)num;
                }
                result = 1d / result;
            }
            return result;
        }

        public static int[] GetDivisibleNumbers(int divisor, int number = 1000)
        {
            if (number < 1 || divisor < 1)
            {
                throw new Exception("Делитель и верхнее число диапазона должны быть больше 0");
            }
            if (divisor > number)
            {
                throw new Exception("делитель не должен быть больше, чем верхнее число диапазона");
            }
            int[] divisibleNumbers = new int[number / divisor];
            int j = 0;
            for (int i = divisor; i <= number; i += divisor)
            {
                divisibleNumbers[j] = i;
                j++;
            }
            return divisibleNumbers;
        }

        public static int CountNumbersWhichSquearsLessA(int number = 100)
        {
            if (number <= 0)
            {
                throw new Exception("Вводимое число должно быть больше 0");
            }
            int i;
            i = 1;
            while (i * i < number)
            {
                i += 1;
            }
            return i - 1;
        }

        public static int GetMaxDivisor(int number = 100)
        {
            if (number == 0)
            {
                throw new Exception("Вводимое число должно быть отличным от 0");
            }
            if (number < 0)
            {
                number *= -1;
            }
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return number / i;
                }
            }

            //for (int i = 1; i < number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        result = i;
            //    }
            //}
            return 1;
        }

        public static int GetSumOfDivisors(int range1 = 1, int range2 = 100, int divisor = 7)
        {
            int result = 0;
            if (range1 <= range2)
            {
                for (int i = range1; i <= range2; i++)
                {
                    if (i % divisor == 0)
                    {
                        result += i;
                    }
                }
            }
            else
            {
                for (int i = range2; i <= range1; i++)
                {
                    if (i % divisor == 0)
                    {
                        result += i;
                    }
                }
            }
            return result;
        }

        public static int GetFibonacciNumber(int n)
        {
            if (n <=0)
            {
                throw new Exception("Введенное число должно быть больше 0");
            }
            
            int n1 = 1;
            int n2 = 1;
            int result = 1;
            for (int i = 2; i < n; i++)
            {
                result = n1 + n2;
                n1 = n2;
                n2 = result;
            }
            return result;
        }
        public static int GetMaxCommonDivisor(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 || b == 0)
            {
                if (a == b)
                {
                    throw new Exception("оба числа равны 0, любое число является для них общим делителем");
                }
                else
                {
                    if (b > a)
                    {
                        a = b;
                    }
                }
            }
            else
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }
            }
            return a;
        }
        public static double GetCubeRoot(double a, double accuracy = 0.00001)
        {
            if (a < 1)
            {
                throw new Exception("Введенное число должно быть не меньше 1");
            }
            double x = 0;
            double border1 = 1;
            double border2 = a;
            double qw = Math.Pow(x + accuracy, 3);
            double qw3 = Math.Pow(x - accuracy, 3);
            while (Math.Pow(x + accuracy, 3) < a
            || Math.Pow(x - accuracy, 3) > a)
            {
                x = (border1 + border2) / 2;
                if (x * x * x < a)
                {
                    border1 = x;
                }
                else
                {
                    border2 = x;
                }
            }
            return x;
        }

        public static int CountOddNumbers(int number)
        {
            int i = 0;
            number = Math.Abs(number);
            while (number != 0)
            {
                if (number % 2 == 1)
                {
                    i++;
                }
                number /= 10;
            }
            return i;
        }

        public static int ReversNumber(int number)
        {
            string result = "";
            if (number < 0)
            {
                result = "-";
                number *= -1;
            }
            else
            {
                result = "";
            }
            do
            {
                result = result + (number % 10);
                number /= 10;
            }
            while (number != 0);
            return Convert.ToInt32(result);
        }

        public static int[] GetNumbersWithSumOfEvenMoreThenSumOfOdd(int number)
        {
            if (number < 1)
            {
                throw new Exception("Введенное число должно быть больше 0");
            }
            int i2 = 0;
            int i3 = 0;
            int even;
            int odd;
            int[] tempArray = new int[number];
            for (int i = 1; i <= number; i++)
            {
                even = 0;
                odd = 0;
                i2 = i;
                while (i2 != 0)
                {
                    if (i2 % 2 == 1)
                    {
                        odd += i2 % 10;
                    }
                    else
                    {
                        even += i2 % 10;
                    }
                    i2 /= 10;
                }
                if (even > odd)
                {
                    tempArray[i3] = i;
                    i3++;
                }
            }
            int[] result = new int[i3];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = tempArray[i];
            }
            return result;
        }

        public static bool CheckMatchOfNumbers(int a, int b)
        {
            if (a < 0)
            {
                a *= -1;
            }
            if(b < 0)
            {
                b *= -1;
            }
            
            int tmpa;
            int tmpb;
            bool result = false;
            do
            {
                tmpa = a % 10;
                tmpb = b;
                do
                {
                    if (tmpa == tmpb % 10)
                    {
                        result = true;
                        break;
                    }
                    tmpb /= 10;
                }
                while (tmpb != 0);
                a /= 10;
            }
            while (a != 0);
            return result;
        }
    }
}
