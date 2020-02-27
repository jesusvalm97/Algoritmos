using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un texto");
            String texto;
            texto = Console.ReadLine().ToLower();

            char[] textoArray = texto.ToCharArray();
            int textoArrayLength = textoArray.Length;
            bool palindromo = true;

            for (int i = 0; i < textoArray.Length; i ++, textoArrayLength--)
            {
                if (textoArray[i] == textoArray[textoArrayLength - 1])
                {
                    palindromo = true;
                }
                else
                {
                    palindromo = false;
                }
            }

            if (palindromo == true)
            {
                Console.WriteLine("Es un palindromo.");
            }
            else
            {
                Console.WriteLine("No es un palindromo.");
            }

            Console.ReadLine();

        }
    }
}
