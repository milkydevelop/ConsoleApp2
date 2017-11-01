using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=50;
            do
            {
            if (i % 2 == 1)
                {
                    Console.WriteLine("{0}", i);
                    i--;
                }
                else
                {
                    i--;
                }
                
            } while (i > 1);
        }
    }
}
