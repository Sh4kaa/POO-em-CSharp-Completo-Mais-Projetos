using System;

namespace exercicio1
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        //método (Função dentro da própria classe)
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
