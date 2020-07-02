using System;
using System.Globalization;

namespace comperable.Entities
{
    class Employee : IComparable // implementado a interface Icomparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        // construtor
        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(','); // removendo as virgulas e criando as posições
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        // transformando os objetos  da classe em string
        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
        public int CompareTo(object obj) // implementado o método da interface IComparable
        {
            if (!(obj is Employee)) // se o o obj não for do tipo employee, gere uma excessão
            {
                throw new ArgumentException("Comparing error: argument is not an Employee"); // nessa linha a operação será finalizada
            }
            Employee other = obj as Employee; // criando objeto "other" do tipo employee e atribuindo e informando que ele é do tipo employee
            return Name.CompareTo(other.Name); //retornando o nome comparado com outro nome
        }
    }
}
