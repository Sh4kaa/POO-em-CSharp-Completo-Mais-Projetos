using System;
using System.Globalization;
namespace Exercicioretangulo
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura); // formula teorema de pitagoras( digonal é o mesmo que RAIZ QUADRADA DE (catetos²))
        }
    }
}
