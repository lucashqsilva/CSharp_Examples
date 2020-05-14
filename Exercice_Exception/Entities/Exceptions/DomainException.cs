using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_Exception.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base(message)
        {

        }
    }
}
