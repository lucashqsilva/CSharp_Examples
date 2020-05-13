using System;
using System.Collections.Generic;
using System.Text;

namespace Excecoes_personalizadas.Entities.Exceptions
{
    // EXCEPTION CRIADA PARA TRATAR ERROS DA RESERVA DE HOTEL!
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
