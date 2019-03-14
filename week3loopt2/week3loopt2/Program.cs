using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3loopt2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("7 times table:");
            Console.WriteLine("----------------");
            Console.WriteLine(">>> for loop <<<\t\t>>> while loop <<<\t\t>>> do while loop<<<");
            for (int i =1; i < 13; i++)
            {
                Console.WriteLine($"{i} x 7 = {i*7}");
            }
            Console.ReadKey();
        }
    }
}
