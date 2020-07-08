using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroRomano
{
    class Program
    {
        static void Main(string[] args)
        {
            int selector = 0;
            int validator = 1;

            Console.WriteLine("Escribe a que convertidor deseas acceder.");
            Console.WriteLine("0 = Numero natural a romano.");
            Console.WriteLine("1 = Romano a numero natuarl");
            selector = int.Parse(Console.ReadLine());

            if(selector == 0)
            {
                int numeroNatural = 0;
                while (validator == 1)
                {
                    Console.WriteLine("Escribe un numero natural: ");
                    numeroNatural = int.Parse(Console.ReadLine());

                    Console.WriteLine("Numero romano " + Convert.ToRomano(numeroNatural));
                    Console.WriteLine("Quieres hacer otra conversión? Si = 1 No = 0");
                    validator = int.Parse(Console.ReadLine());
                }
            }
            else if(selector == 1)
            {
                string numeroRomano = "";

                while (validator == 1)
                {
                    Console.WriteLine("Escribe un numero romano:");
                    numeroRomano = Console.ReadLine();

                    Console.WriteLine("Numero natural " + Convert.ToNatuaralNumber(numeroRomano));
                    Console.WriteLine("Quieres hacer otra conversión? Si = 1 No = 0");
                    validator = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
