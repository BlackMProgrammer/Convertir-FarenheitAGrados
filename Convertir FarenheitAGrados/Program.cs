using System;

namespace Convertir_FarenheitAGrados
{
    class Program
    {
        static void Main(string[] args)
        {
           int enFarenheit = 90;
            Console.WriteLine("Convertir {0} Grados Farenheit a Grados Celcius", enFarenheit);

            double enCelcius = (enFarenheit - 32) * 5 / 9;
            Console.WriteLine("Los {0} Grados Farenheit equivalen a {1} Grados celcius", enFarenheit, enCelcius);
        }
    }
}
