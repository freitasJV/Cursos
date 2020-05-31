using System;
using System.Collections.Generic;

namespace Cursos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"What id for student {i}? ");
                int cod = int.Parse(Console.ReadLine());
                set.Add(cod);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"What id for student {i}? ");
                int cod = int.Parse(Console.ReadLine());
                set.Add(cod);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"What id for student {i}? ");
                int cod = int.Parse(Console.ReadLine());
                set.Add(cod);
            }

            Console.WriteLine($"Total Students: {set.Count}");
        }
    }
}
