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
            int numeroNatural = 0;
            string numeroRomano = "";
            int validator = 1;

            while (validator == 1)
            {
                Console.WriteLine("Escribe un numero natural: ");
                numeroNatural = int.Parse(Console.ReadLine());

                if (numeroNatural >= 1000)
                {
                    int M = numeroNatural / 1000;
                    for (int m = 0; m < M; m++, numeroNatural -= 1000)
                    {
                        numeroRomano += "M";
                    }
                }

                if (numeroNatural >= 500 && numeroNatural < 1000)
                {
                    if (numeroNatural / 100 == 9)
                    {
                        numeroRomano += "CM";
                        numeroNatural -= 900;
                    }
                    else
                    {
                        numeroRomano += "D";
                        numeroNatural -= 500;
                        int C = numeroNatural / 100;
                        for (int c = 0; c < C; c++, numeroNatural -= 100)
                        {
                            numeroRomano += "C";
                        }
                    }
                }

                if (numeroNatural < 500 && numeroNatural >= 100)
                {
                    int C = numeroNatural / 100;
                    for (int c = 0; c < C; c++, numeroNatural -= 100)
                    {
                        if (C == 4)
                        {
                            numeroRomano += "CD";
                            numeroNatural -= 400;
                            break;
                        }
                        else
                        {
                            numeroRomano += "C";
                        }
                    }
                }

                if (numeroNatural < 100 && numeroNatural >= 50)
                {
                    if (numeroNatural / 10 == 9)
                    {
                        numeroRomano += "XC";
                        numeroNatural -= 90;
                    }
                    else
                    {
                        numeroRomano += "L";
                        numeroNatural -= 50;
                        int X = numeroNatural / 10;
                        for (int x = 0; x < X; x++, numeroNatural -= 10)
                        {
                            numeroRomano += "X";
                        }
                    }
                }

                if (numeroNatural < 50 && numeroNatural >= 10)
                {
                    int X = numeroNatural / 10;
                    for (int x = 0; x < X; x++, numeroNatural -= 10)
                    {
                        if (X == 4)
                        {
                            numeroRomano += "XL";
                            numeroNatural -= 40;
                            break;
                        }
                        else
                        {
                            numeroRomano += "X";
                        }
                    }
                }

                if (numeroNatural < 10 && numeroNatural >= 5)
                {
                    if (numeroNatural == 9)
                    {
                        numeroRomano += "IX";
                        numeroNatural -= 9;
                    }
                    else
                    {
                        numeroRomano += "V";
                        numeroNatural -= 5;
                        int I = numeroNatural;
                        for (int i = 0; i < I; i++, numeroNatural--)
                        {
                            numeroRomano += "I";
                        }
                    }
                }

                if (numeroNatural > 0 && numeroNatural < 5)
                {
                    int I = numeroNatural;
                    for (int i = 0; i < I; i++, numeroNatural--)
                    {
                        if (I == 4)
                        {
                            numeroRomano += "IV";
                            numeroNatural -= 4;
                            break;
                        }
                        else
                        {
                            numeroRomano += "I";
                        }
                    }
                }

                Console.WriteLine("Numero romano " + numeroRomano);
                Console.WriteLine("Quieres hacer otra conversión? Si = 1 No = 0");
                validator = int.Parse(Console.ReadLine());
                numeroRomano = "";
            }
        }
    }
}
