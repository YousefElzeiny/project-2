using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2_perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number :");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = n1; i <= n2; i++)
            {
                int sum = 0;
                for (int f = 1; f < i; f++)
                {
                    if (i % f == 0)
                        sum += f;
                }
                if (sum == i)
                    Console.WriteLine(i);

            }
        }
    }
}
