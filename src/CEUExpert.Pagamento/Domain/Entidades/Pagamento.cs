using CEU.Core.Domain.Entities;
using CEU.Core.Domain.Exceptions;

namespace CEU.Pagamento.Domain.Entidades
{
    public class Pagamento : EntidadeBase
    {
        public decimal Valor { get; private set; }
        public string Metodo { get; private set; }

        public Pagamento(decimal valor, string metodo)
        {
            if (valor <= 0) throw new DomainException("Valor inválido");
            if (string.IsNullOrWhiteSpace(metodo)) throw new DomainException("Método inválido");

            Valor = valor;
            Metodo = metodo;
        }
    }
}