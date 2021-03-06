using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys
{
    public static class Branches
    {
        public static int GetDifferenceOrProduct(int a, int b)
        {
            if (a > b)
            {
                a += b;
            }
            else
            {
                if (a < b)
                {
                    a -= b;
                }
                else
                {
                    a *= b;
                }
            }
            return a;
        }
        public static int GetQuarter(int x, int y)
        {
            int quarter;
            if (x == 0 || y ==0)
            {
                quarter = 0;
            }
            else
            {
                if (y > 0)
                {
                    if (x > 0)
                    {
                        quarter = 1;
                    }
                    else
                    {
                        quarter = 2;
                    }
                }
                else
                {
                    if (x > 0)
                    {
                        quarter = 4;
                    }
                    else
                    {
                        quarter = 3;
                    }
                }
            }
            return quarter;
            
        }
        public static int[] SortThreeNumbers(int a, int b, int c)
        {
            int[] result = new int[3];
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        result[0] = c;
                        result[1] = b;
                        result[2] = a;
                    }
                    else
                    {
                        result[0] = b;
                        result[1] = c;
                        result[2] = a;
                    }
                }
                else
                {
                    result[0] = b;
                    result[1] = a;
                    result[2] = c;
                }
            }
            else
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        result[0] = c;
                        result[1] = a;
                        result[2] = b;
                    }
                    else
                    {
                        result[0] = a;
                        result[1] = c;
                        result[2] = b;
                    }
                }
                else
                {
                    result[0] = a;
                    result[1] = b;
                    result[2] = c;
                }
            }
            return result;
        }

        public static double[] GetXOfQuadraticEquation(double a, double b, double c)
        {
            
            if (d < 0)
            {
                throw new Exception("Дескриминант меньше 0, решений нет");
            }
            else
            {
                double x1;
                double x2;
                double d;
                d = b * b - 4 * a * c;
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                if (d == 0)
                {
                    double[] result = { x1 };
                    return result;
                }
                else
                {
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    double[] result = { x1, x2 };
                    return result;
                }
            }
        }

        public static string ConvertNumberToText(int number)
        {
            number = Math.Abs(number);
            if (number < 10 || number > 99)
            {
                throw new Exception("Введенное число должно быть двухзначным");
            }
            int num1;
            int num2;
            string str = "";
            num1 = number / 10;
            num2 = number % 10;
            if (number < 20)
            {
                switch (number)
                {
                    case 10:
                        str = "десять";
                        break;
                    case 11:
                        str = "одиннадцать";
                        break;
                    case 12:
                        str = "двенадцать";
                        break;
                    case 13:
                        str = "тринадцать";
                        break;
                    case 14:
                        str = "четырнадцать";
                        break;
                    case 15:
                        str = "пятнадцать";
                        break;
                    case 16:
                        str = "шестнадцать";
                        break;
                    case 17:
                        str = "семнадцать";
                        break;
                    case 18:
                        str = "восемнадцать";
                        break;
                    case 19:
                        str = "девятнадцать";
                        break;
                }
                return str;
            }
            else
            {
                switch (num1)
                {
                    case 2:
                        str = "двадцать";
                        break;
                    case 3:
                        str = "тридцать";
                        break;
                    case 4:
                        str = "сорок";
                        break;
                    case 5:
                        str = "пятьдесят";
                        break;
                    case 6:
                        str = "шестьдесят";
                        break;
                    case 7:
                        str = "семьдесят";
                        break;
                    case 8:
                        str = "восемьдесят";
                        break;
                    case 9:
                        str = "девяносто";
                        break;
                }
                switch (num2)
                {
                    case 0:
                        str += "";
                        break;
                    case 1:
                        str += " один";
                        break;
                    case 2:
                        str += " два";
                        break;
                    case 3:
                        str += " три";
                        break;
                    case 4:
                        str += " четыре";
                        break;
                    case 5:
                        str += " пять";
                        break;
                    case 6:
                        str += " шесть";
                        break;
                    case 7:
                        str += " семь";
                        break;
                    case 8:
                        str += " восемь";
                        break;
                    case 9:
                        str += " девять";
                        break;

                }
                return str;
            }
        }
    }
}
