using System.Globalization;


namespace properties
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; } // auto properties
        public int Quantidade { get;  private set; } // auto properties

        /* auto properties se usa apenas caso não utilize de nenhuma lógica */

        //construtor padrão
        public Produto()
        {
        }

        //construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //gets sets (metodo)
        // properties
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }     
            
       
        //métodos
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}