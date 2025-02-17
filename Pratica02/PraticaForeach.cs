using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace PraticaForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++)
            {
                vet[x] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos: ");
            foreach (string x in vet)
            {
                Console.WriteLine(vet[x]);
            }
            Console.ReadLine();

              
        }
    }
}
