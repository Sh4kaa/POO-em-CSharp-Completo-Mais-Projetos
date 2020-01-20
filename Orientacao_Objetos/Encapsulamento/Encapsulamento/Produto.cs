using System.Globalization;


namespace Encapsulamento
{
    class Produto
    {
        private string _nome; // para prive,d evemos adotar um padrão de nomeclatura
        private double _preco;
        private int _quantidade;

        // construtor padrão
        public Produto()
        {

        }


        // construtor com 3 argumentos
        public Produto( string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _preco = quantidade;
        }                


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }



        public override string ToString()
        {
            return _nome + ", $ " + _preco.ToString("f2", CultureInfo.InvariantCulture)
                + ", " + _quantidade + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
