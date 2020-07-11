using System;
using System.Collections.Generic;
using System.Text;

namespace RicoPollo
{
    public class Conversion
    {
        public static double DineroACubitosRicoPollo(double dinero)
        {
            double cubitosRicoPollo = (dinero * 3) / 5;
            return cubitosRicoPollo;
        }

        public static double CubitosRicoPolloADinero(double cubitosRicoPollo)
        {
            double dinero = (cubitosRicoPollo * 5) / 3;
            return dinero;
        }
    }
}
