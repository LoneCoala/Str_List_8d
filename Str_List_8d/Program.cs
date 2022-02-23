using System;
using System.Collections.Generic;

namespace Str_List_8d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("начальный список:");
            List<string> people = new List<string>() { "Tom", "Bob", "Sam", "Aaa", "12321", "Але", "ксандр" };
            for (int i = 0; i < people.Count; i++)
            {
                Console.Write(people[i] + " ");
            }

            RevList(people);

            Console.WriteLine("\nновый список:");
            for (int i = 0; i < people.Count; i++)
            {
                Console.Write(people[i] + " ");
            }


            List<string> RevList(List<string> list)
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
