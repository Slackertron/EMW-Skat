using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Skat
{
    public static class Afgift
    {
        // Jeg har valgt at lave en metode i stedet for to, da der vil være meget gentagende kode for de to metoder.

        /// <summary>
        /// Beregner bilafgiften ud fra prisen af bilen.
        /// Hvis prisen er under 200.000kr, så er afgiften bilen pris gange 0,85.
        /// Hvis prisen er over 200.000kr, så er afgiften bilen pris gange 1,50 og minus 130.000.
        /// Hvis typen af bil er elbil, så bliver afgiften ganget med 0,20.
        /// Hvis prisen er under 0kr, smider methoden en exception.
        /// </summary>
        /// <param name="pris"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static double BilAfgift(double pris, string type)
        {
            double bilAfgift = 0;
            if (pris < 0 || pris >= double.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
            }

            bilAfgift = pris * 0.85;

            if (pris > 200000)
            {
                bilAfgift = (pris * 1.50) - 130000;
            }

            if (type == "Elbil")
            {
                bilAfgift = bilAfgift * 0.20;
            }

            return bilAfgift;
        }
    }
}
