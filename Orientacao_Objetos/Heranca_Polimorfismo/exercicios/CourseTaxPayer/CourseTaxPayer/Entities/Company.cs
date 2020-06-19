

namespace CourseTaxPayer.Entities
{
    class Company : TaxPayer
    {
        public int NumerOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numerOfEmployees): base(name, anualIncome)
        {
            NumerOfEmployees = numerOfEmployees;
        }

        public override double Tax()
        {
            if (NumerOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            } else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
