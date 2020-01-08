using System;
using System.Globalization;
namespace exerci2funcionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        // metódos
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto +=  SalarioBruto * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return Nome +" R$ " + SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
