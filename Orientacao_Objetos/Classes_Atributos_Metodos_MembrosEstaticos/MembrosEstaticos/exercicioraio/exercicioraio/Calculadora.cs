using System;

namespace exercicioraio
{
    class Calculadora
    {
       public static double Pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r; // formula do raio
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0); // 4 terços de * Pi * raio elevado ao cubo. formula do volume
        }
    }
}
