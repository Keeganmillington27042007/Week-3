using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_loops_t1
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 3;
            int finish = 7;

            Console.WriteLine("N\t10*N\t\t100*N\t\t1000*N");
            Console.WriteLine("***********For loop**********");
            for (int i = start; i <= finish; i++)
            {

                Console.WriteLine($"{i}\t\t{i * 10}\t\t{i * 100}\t\t{i * 1000}");

            }
            Console.WriteLine("End of the loop.....");
            Console.ReadKey();
            int counter = 1;
            while (counter <= finish)
            {
                Console.WriteLine($"{counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}");
                counter = 3;
            }
            do
            {
                Console.WriteLine($"{counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}");
                counter = 3;
            } while (counter <= finish);




        }
    }
}
