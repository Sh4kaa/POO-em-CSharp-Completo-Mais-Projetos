namespace contratoEmpresa2.Services
{
    class ServicoPayPal : IServicoDePagamentoOnline
    {
        private const double TaxaPercentual = 0.02;
        private const double JurosMes = 0.01;

        public double Juros(double quantia, int meses) // método
        {
            return quantia * JurosMes * meses;
        }

        public double TaxaDePagamento(double quantia)
        {
            return quantia * TaxaPercentual;
        }


    }
}