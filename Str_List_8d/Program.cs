using System;
using System.Collections.Generic;

namespace Str_List_8d
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = new List<string>() { "Tom", "Bob", "Sam" };
            Console.WriteLine("Начальный список:");
            for (int i = 0; i < people.Count; i++)
            {
                Console.Write(people[i] + " ");
            }
            Console.WriteLine("Сколько элементов добавить в список?");
            int n = 0;

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Введена неверная форма числа! Попробуйте снова.");
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите новый элемент списка №{i + 1}:");
                people.Add(Console.ReadLine());
                Console.WriteLine("");
            }

            Console.WriteLine("Новый список до изменений:");
            for (int i = 0; i < people.Count; i++)
            {
                Console.Write(people[i] + " ");
            }
            Console.WriteLine("\nПеренести последний элемент в начало, добавить элементы или закончить выполнение программы?\n1.Перенести\n2.Добавить\n0.Закончить");
            string choose = "";
            while (choose!= "0")
            {
                choose = Console.ReadLine();
                if (choose == "2")
                {
                    Console.WriteLine("Начальный список:");
                    for (int i = 0; i < people.Count; i++)
                    {
                        Console.Write(people[i] + " ");
                    }
                    Console.WriteLine("Сколько элементов добавить в список?");
                    n = 0;

                    while (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("Введена неверная форма числа! Попробуйте снова.");
                    }

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Введите новый элемент списка №{i + 1}:");
                        people.Add(Console.ReadLine());
                        Console.WriteLine("");
                    }
                }
                if (choose == "1")
                {
                    MoveToBeginningOfList(people);
                }
                if (choose == "0")
                {
                    break;
                }
                Console.WriteLine("\nНовый список:");
                for (int i = 0; i < people.Count; i++)
                {
                    Console.Write(people[i] + " ");
                }
                Console.WriteLine("\nПеренести последний элемент в начало, добавить элементы или закончить выполнение программы?\n1.Перенести\n2.Добавить\n0.Закончить");
            }

            Console.WriteLine("Конец работы программы");


            List<string> MoveToBeginningOfList(List<string> list)
            {
                string str = list[list.Count - 1];
                list.Reverse();
                list.Add(str);
                list.Reverse();
                list.RemoveAt(list.Count - 1);
                return list;
            }
        }
    }
}
