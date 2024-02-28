using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bestäm triangelns höjd:");
            int höjd = int.Parse(Console.ReadLine());
            Triangel(höjd);
        }

        static void Triangel(int höjd)
        {
            for (int i = 0; i < höjd; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}