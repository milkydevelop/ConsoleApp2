using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Random liczba = new Random();
            double[] tablica = new double[100];

            for (i=0; i < tablica.Length; i++)
            {
                tablica[i] = liczba.NextDouble();
            }
            var query = tablica.Select(n => n).ToArray();
            foreach (var item in query)
            {
                Console.WriteLine(item + ", ");
            }


        }
    }
}
