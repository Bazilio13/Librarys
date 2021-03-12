using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys
{
    public static class Branches
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
                        "\nРАЗДЕЛ \"СТРУКТУРЫ ВЕТВЛЕНИЙ\"" +
                        "\n1. Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B" +
                        "\n2. Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y)" +
                        "\n3. Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания" +
                        "\n4. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0" +
                        "\n5. Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”");
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
                        Console.WriteLine($"Результат: {GetDifferenceOrProduct(a, b)}");
                        break;
                    case "2":
                        Console.WriteLine("Введите значения X и Y");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        a = GetQuarter(a, b);
                        if (a == 0)
                        {
                            Console.WriteLine($"Точка не принадлежит ни одной из четвертей");
                        }
                        else
                        {
                            Console.WriteLine($"Точка принадлежит четверти {a}");
                        }
                        break;
                    case "3":
                        int c;
                        Console.WriteLine("Введите числа А, В и С");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Результат: ");
                        Arrays1Demensional.PrintArrayOfInts(SortThreeNumbers(a, b, c));
                        break;
                    case "4":
                        Console.WriteLine("Введите числа А, В и С");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        c = Convert.ToInt32(Console.ReadLine());
                        double[] result;
                        result = GetXOfQuadraticEquation(a, b, c);
                        Console.WriteLine($"Количество корней уравнения {result.Length}:");
                        Arrays1Demensional.PrintArrayOfDoubles(result);
                        break;
                    case "5":
                        Console.WriteLine("Введите число");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Текстовый формат числа: {ConvertNumberToText(a)}");
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
            double d;
            d = b * b - 4 * a * c;
            if (d < 0)
            {
                throw new Exception("Дескриминант меньше 0, решений нет");
            }
            else
            {
                double x1;
                double x2;
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
            string result = "";
            if (number < 0)
            {
                result = "минус ";
            }
            number = Math.Abs(number);
            if (number < 10 || number > 99)
            {
                throw new Exception("Введенное число должно быть двухзначным");
            }
            int num1;
            int num2;
            
            num1 = number / 10;
            num2 = number % 10;
            if (number < 20)
            {
                switch (number)
                {
                    case 10:
                        result += "десять";
                        break;
                    case 11:
                        result += "одиннадцать";
                        break;
                    case 12:
                        result += "двенадцать";
                        break;
                    case 13:
                        result += "тринадцать";
                        break;
                    case 14:
                        result += "четырнадцать";
                        break;
                    case 15:
                        result += "пятнадцать";
                        break;
                    case 16:
                        result += "шестнадцать";
                        break;
                    case 17:
                        result += "семнадцать";
                        break;
                    case 18:
                        result += "восемнадцать";
                        break;
                    case 19:
                        result += "девятнадцать";
                        break;
                }
                return result;
            }
            else
            {
                switch (num1)
                {
                    case 2:
                        result += "двадцать";
                        break;
                    case 3:
                        result += "тридцать";
                        break;
                    case 4:
                        result += "сорок";
                        break;
                    case 5:
                        result += "пятьдесят";
                        break;
                    case 6:
                        result += "шестьдесят";
                        break;
                    case 7:
                        result += "семьдесят";
                        break;
                    case 8:
                        result += "восемьдесят";
                        break;
                    case 9:
                        result += "девяносто";
                        break;
                }
                switch (num2)
                {
                    case 0:
                        result += "";
                        break;
                    case 1:
                        result += " один";
                        break;
                    case 2:
                        result += " два";
                        break;
                    case 3:
                        result += " три";
                        break;
                    case 4:
                        result += " четыре";
                        break;
                    case 5:
                        result += " пять";
                        break;
                    case 6:
                        result += " шесть";
                        break;
                    case 7:
                        result += " семь";
                        break;
                    case 8:
                        result += " восемь";
                        break;
                    case 9:
                        result += " девять";
                        break;

                }
                return result;
            }
        }
        
    }
}
