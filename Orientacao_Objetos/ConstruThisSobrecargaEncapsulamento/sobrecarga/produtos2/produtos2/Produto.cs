using System.Globalization;

namespace produtos2
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //construtor 1
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //construtor 2 SOBRECARGA

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5; // ainda assim não é necessario adicionar valores se no caso quiser que seja zero, só naõ adicionar o atributo ao construtor
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) // FUNÇÃO COOM VOID
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", " + Quantidade + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        /* QUANDO OS PARAMETROS DA FUNÇÃO JÁ ESTÃO NA CLASSE, É NECESSARIO TER UM RETURN
        NO CASO UAM FUNÇÃO VAZIA (VOID), EM QUE OS PARAMETROS ESTÃO EM OUTRO LUGAR E VAMOS PEGA-LOS
        A FUNÇÃO TEM QUE TER VOID*/
    }
}
