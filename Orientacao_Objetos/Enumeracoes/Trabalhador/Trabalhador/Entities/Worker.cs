using System.Collections.Generic;
using Trabalhador.Entities.Enums;
namespace Trabalhador.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        // construtor padrão = vazio
        public Worker()
        {

        }
        // construtor com 4 argumentos PS: quando tem uam associação para muitos naõ é necessario criar construtor
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        // método add contract
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        // método remover contrato
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        // método ganho
        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContract contract in Contracts )
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
