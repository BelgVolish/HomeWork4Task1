using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int n = int.Parse(Console.ReadLine());
            int[,] randomarry = new int[m, n];
            Random r = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int ii = 0; ii < n; ii++)
                {
                    randomarry[i, ii] = r.Next(0, 100);
                    Console.Write(randomarry[i, ii] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}