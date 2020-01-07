using System;
using System.Globalization;

namespace produtos
{
    class Produto
    {
        // atributos
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("f2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }



    }
}
