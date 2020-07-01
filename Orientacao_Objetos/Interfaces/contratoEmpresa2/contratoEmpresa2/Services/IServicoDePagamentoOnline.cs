namespace contratoEmpresa2.Services
{
    interface IServicoDePagamentoOnline
    {
        double TaxaDePagamento(double quantia);
        double Juros(double quantia, int meses);
    }
}
