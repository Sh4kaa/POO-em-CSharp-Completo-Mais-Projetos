using System;
using System.Collections.Generic;


namespace contratoEmpresa2.Entities
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Prestacoes> Prestacoes { get; set; }

        // construtor

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Prestacoes = new List<Prestacoes>(); // estanciando a lista vazia
        }

        public void AddPrestacoes(Prestacoes prestacoes)
        {
            Prestacoes.Add(prestacoes);
        }

    }
}
