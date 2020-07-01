using contratoEmpresa2.Entities;
using System;

namespace contratoEmpresa2.Services
{
    class ServicoDeContrato
    {
        private IServicoDePagamentoOnline _servicoDePagamentoOnline;

        public ServicoDeContrato(IServicoDePagamentoOnline servicoDePagamentoOnline)
        {
            _servicoDePagamentoOnline = servicoDePagamentoOnline;
        }

        // metodo
        public void ProcessarContrato(Contrato contrato, int meses)
        {
            double valorParcela = contrato.ValorTotal / meses;
            for(int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i); // data paga no mes seguinte
                double valorCota = valorParcela + _servicoDePagamentoOnline.Juros(valorParcela, i);
                double cotaTotal = valorCota + _servicoDePagamentoOnline.TaxaDePagamento(valorCota);
                contrato.AddPrestacoes(new Prestacoes(data, cotaTotal));
            }


        }
        
    }
}
