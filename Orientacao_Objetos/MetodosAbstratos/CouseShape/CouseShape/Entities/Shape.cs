

using CouseShape.Enums;

namespace CouseShape.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        // construtor


        public Shape(Color color)
        {
            Color = color;
        }

        // metodo abstrato

        public abstract double Area(); // não é necessario colocar virtual pois a classe é abstrata e ela obrigatóriamente terá QUE SER SUBSTITUIDA
    }
}
