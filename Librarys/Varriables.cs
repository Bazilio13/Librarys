using System;
using System.Collections.Generic;
using System.Text;

namespace Librarys
{
    public static class Varriables
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
                        "\nРАЗДЕЛ \"ПЕРЕМЕННЫЕ\"" +
                        "\n1. Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5*A+B^2)/(B-A)" +
                        "\n2. Пользователь вводит 2 значения(A и B). Поменяйте содержимое переменных A и B местами." +
                        "\n3. Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления." +
                        "\n4. Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C." +
                        "\n5. Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.");
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
                        Console.WriteLine($"(5*A+B^2)/(B-A) = {EvaluateTheExpression(a, b)}");
                        break;
                    case "2":
                        Console.WriteLine("Введите числo А");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите числo В");
                        b = Convert.ToInt32(Console.ReadLine());
                        SwapVars(ref a, ref b);
                        Console.WriteLine($"Теперь А = {a}, B = {b}");
                        break;
                    case "3":
                        Console.WriteLine("Введите числа А и В");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        int[] result;
                        result = DivideWithTheRemainder(a, b);
                        Console.WriteLine($"a/b = {result[0]}, остаток от деления = {result[1]}");
                        break;
                    case "4":
                        Console.WriteLine("Введите числа А, В и С");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        int c;
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"X = {SolveLinearEquation(a, b, c)}");
                        break;
                    case "5":
                        Console.WriteLine("Введите числа X1, Y1, X2 и Y2");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        int d;
                        c = Convert.ToInt32(Console.ReadLine());
                        d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{GetEquationOfStraightLine(a, b, c, d)}");
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

        public static double EvaluateTheExpression(double a, double b)
        {
            if (a == b)
            {
                throw new Exception("А не должно быть равно В");
            }
            double result;
            result = (5 * a + b * b) / (b - a);
            return result;
        }
        public static void SwapVars(ref int a, ref int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
        }

        public static int[] DivideWithTheRemainder(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("В должно быть отлично от 0");
            }
            int[] result = new int[2];
            result[0] = a / b;
            result[1] = a % b;
            return result;
        }

        public static double SolveLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("A должно быть отлично от 0");
            }
            double result;
            result = (c - b) / a;
            return result;
        }

        public static string GetEquationOfStraightLine(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new Exception("X1 не должен быть равен X2");
            }
            string result;
            result = $"Y = {(y2 - y1) / (x2 - x1)}X + {y1 - ((y2 - y1) / (x2 - x1)) * x1}";
            return result;
        }
    }
}
