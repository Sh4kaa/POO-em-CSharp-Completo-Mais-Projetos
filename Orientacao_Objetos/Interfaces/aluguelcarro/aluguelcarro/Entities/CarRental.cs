
using System;

namespace aluguelcarro.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; } //associação
        public Invoice Invoice { get; set; } // associação

        //obs: objeto naõ associado ele já recebe nulo por padrão, mas se quiser incluir no construtor, fica a vonts

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}
