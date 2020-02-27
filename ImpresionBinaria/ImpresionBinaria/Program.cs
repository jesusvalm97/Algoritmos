using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpresionBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0) { Console.WriteLine(0 ); }
                        else { Console.WriteLine(1 ); }
                    }
                    else
                    {
                        if (j % 2 == 0) { Console.WriteLine(1 ); }
                        else { Console.WriteLine(0 ); }
                    }
                }
            }
        }
    }
}
