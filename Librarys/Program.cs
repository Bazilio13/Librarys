using System;

namespace Librarys
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string navigation = "";
            bool showNav = true;
            while (navigation != "exit")
            {
                if (showNav)
                {
                    Console.WriteLine("---------------------------------------------------------------" +
                        "\nДОСТУПНЫЕ РАЗДЕЛЫ" +
                        "\n1. Структуры ветвлений" +
                        "\n2. Циклы" +
                        "\n3. Одномерные массивы" +
                        "\n4. Двумерные массивы");
                }
                Console.WriteLine("" +
                    "\nВведите номер раздела или exit для выхода");
                navigation = Console.ReadLine();
                switch (navigation)
                {
                    case "1":
                        navigation = Branches.ShowMenu();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        
                        break;
                    case "exit":
                        return;
                    default:
                        showNav = false;
                        Console.WriteLine("Введено некорректное значение, для выбора раздела введите цифру от 1 до 4");
                        continue;
                }
                showNav = true;

            }
        }
    }
}
