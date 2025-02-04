using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace Pratica14
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double valor;



            minutos = int.Parse(Console.ReadLine());
            valor = 50.00;
            if (minutos > 100)
            {
                valor = valor + (minutos - 100) * 2.0;
                Console.WriteLine("Valor a pagar: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Valor a pagar: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));

            }

        }
    }
}
