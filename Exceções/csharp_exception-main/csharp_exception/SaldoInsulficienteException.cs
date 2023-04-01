using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception
{
    public class SaldoInsulficienteException : Exception
    {
        public SaldoInsulficienteException()
        {

        }
        public SaldoInsulficienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
