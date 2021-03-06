using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys
{
    public static class Cycles
    {
        public static double RaiseToAPower(int num, int degree)
        {
            double result = 1;

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

        public static int[] GetDivisibleNumbers(int number = 1000, int divisor = 7)
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

        public static int GetDivisibleNumbers(int number = 100)
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
            int n1 = 0;
            int n2 = 1;
            int result = 0;
            int tmp;
            for (int i = 0; i < n; i++)
            {
                result = n2;
                tmp = n1;
                n1 = n2;
                n2 = tmp + n2;
            }
            return result;
        }
        public static int GetMaxCommonDivisor(int a, int b)
        {
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
            while (number != 0)
            {
                if (number % 2 == 1)
                {
                    i += 1;
                }
                number /= 10;
            }
            return i;
        }

        public static int ReversNumber(int number)
        {
            string result = "";
            while (number != 0)
            {
                result = result + (number % 10);
                number /= 10;
            }
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
            
            int tmp;
            bool result = false;
            do
            {
                tmp = a % 10;
                do
                {
                    if (tmp == b % 10)
                    {
                        result = true;
                        break;
                    }
                    b /= 10;
                }
                while (b != 0);
                if (result)
                {
                    break;
                }
                a /= 10;
            }
            while (a != 0);
            return result;
        }
    }
}
