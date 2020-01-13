using System;


namespace conversao
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double CotacaoDolar(double cot, double quantDol)
        {
            double total = cot * quantDol;
            return total + total * Iof / 100.0;         

        }

        
    }
}
