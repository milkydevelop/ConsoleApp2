using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Random rand = new Random();
            for (i = 0; i < 50; i++)
            {
                int a = rand.Next(1, 100);
                if (a % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}