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
                        "\n1. Переменные" +
                        "\n2. Структуры ветвлений" +
                        "\n3. Циклы" +
                        "\n4. Одномерные массивы" +
                        "\n5. Двумерные массивы");
                }
                Console.WriteLine("" +
                    "\nВведите номер раздела или exit для выхода");
                navigation = Console.ReadLine();
                switch (navigation)
                {
                    case "1":
                        navigation = Varriables.ShowMenu();
                        break;
                    case "2":
                        navigation = Branches.ShowMenu();
                        break;
                    case "3":
                        navigation = Cycles.ShowMenu();
                        break;
                    case "4":
                        navigation = Arrays1Demensional.ShowMenu();
                        break;
                    case "5":
                        navigation = Arrays2Demensional.ShowMenu();
                        break;
                    case "exit":
                        return;
                    default:
                        showNav = false;
                        Console.WriteLine("Введена неизвестная команда");
                        continue;
                }
                showNav = true;

            }
        }
    }
}
