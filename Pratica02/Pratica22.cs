using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace Pratica22

{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char repetir;
            do
            {
                Console.Write("Digita a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine());


            } while (repetir == 's');
        }
    }
}