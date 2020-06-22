using System;

namespace conta.Entities.Exceptions
{
    class DomainException :ApplicationException
    {
        public DomainException(string message): base(message)
        {

        }
    }
}
