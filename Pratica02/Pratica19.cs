using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace Pratica19
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            valor = int.Parse(Console.ReadLine());
            for (int i = 1 ; i<=10; i++)
            {
                int resultado = i * valor;
                Console.WriteLine(i + " x " + valor + " = " + resultado);
            }

            Console.ReadLine();



        }
    }
}
