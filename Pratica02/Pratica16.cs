using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace Pratica16
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            String[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("Decrescente");

                }
                else
                {
                    Console.WriteLine("Crscente");

                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
            Console.ReadLine();


        }
    }
}
