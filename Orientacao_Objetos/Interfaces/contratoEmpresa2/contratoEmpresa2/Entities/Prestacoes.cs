using System;
using System.Globalization;


namespace contratoEmpresa2.Entities
{
    class Prestacoes
    {
        public DateTime Data { get; set; }
        public double Quantia { get; set; }

        public Prestacoes(DateTime data, double quantia)
        {
            Data = data;
            Quantia = quantia;
        }

        public override string ToString()
        {
            return Data.ToString("dd/MM/yyyy")
                + " - "
                + Quantia.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
