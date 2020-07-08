using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroRomano
{
    class Convert
    {
        public static string ToRomano(int numeroNatural)
        {
            string numeroRomano = "";

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

            return numeroRomano;
        }

        public static int ToNatuaralNumber(string numeroRomano)
        {
            int numeroNatural = 0;

            char[] romanoArray = numeroRomano.ToUpper().ToCharArray();

            for(int i = 0; i < romanoArray.Length; i++)
            {
                if (romanoArray[i] == 'M')
                {
                    numeroNatural += 1000;
                    romanoArray[i] = ' ';
                }

                if(romanoArray[i] == 'D')
                {
                    numeroNatural += 500;
                    romanoArray[i] = ' ';
                }

                if(romanoArray[i] == 'C')
                {
                    numeroNatural += 100;
                    romanoArray[i] = ' ';
                }

                if(romanoArray[i] == 'L')
                {
                    numeroNatural += 50;
                    romanoArray[i] = ' ';
                }

                if(romanoArray[i] == 'X')
                {
                    numeroNatural += 10;
                    romanoArray[i] = ' ';
                }

                if(romanoArray[i] == 'V')
                {
                    numeroNatural += 5;
                    romanoArray[i] = ' ';
                }

                if(romanoArray[i] == 'I')
                {
                    numeroNatural += 1;
                    romanoArray[i] = ' ';
                }
            }

            return numeroNatural;
        }
    }
}
