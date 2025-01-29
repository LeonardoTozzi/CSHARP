using System;
using System.Globalization;
using System.Numerics;

namespace Pratica02
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] peca = Console.ReadLine().Split(' ');
            string cod = peca[0];
            int quant = int.Parse(peca[1]);
            double valor = double.Parse(peca[2], CultureInfo.InvariantCulture);

            string[] peca2 = Console.ReadLine().Split(' ');
            string cod2 = peca2[0];
            int quant2 = int.Parse(peca2[1]);
            double valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double total = (quant * valor) + (quant2*valor2);
            
       

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}