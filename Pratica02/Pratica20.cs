using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace Pratica20
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max, soma;

            x = int.Parse(Console.ReadLine()); //Digita o Primeiro número
            y = int.Parse(Console.ReadLine()); //Digita o Segundo número

            if (x < y) //A função if e else serve para que a ordem dos fatores não aletra o prdotuo
            {          // Também vai definir o min e o max 
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }
            soma = 0; 
            for (int i=min+1; i<max; i++)
            {
                if (i % 2 != 0){
                    soma = soma + i;

                }
            }
            Console.WriteLine(soma);

            Console.ReadLine();



        }
    }
}
