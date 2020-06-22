using System;


namespace ReservaHotel.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        // construtor
        public DomainException(string message) :base(message) // recebe a mensagem personalizada e passa oa contrutor ad classe application a mensagem
        {

        }
    }
}
