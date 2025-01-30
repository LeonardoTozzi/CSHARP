using System;
using System.Globalization;
using System.Numerics;

namespace Pratica03
{
    class Pratica03
    {
        static void Main(string[] args)
        {
            int x; /*distância*/
            double y, z; /*combustível*/

            
            x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            

            z = x / y;


            Console.WriteLine(z.ToString("F3", CultureInfo.InvariantCulture) + " km/1");


            

            Console.ReadLine();

        }
    }
}