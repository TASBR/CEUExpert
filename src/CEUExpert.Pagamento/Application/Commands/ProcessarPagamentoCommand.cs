using MediatR;

namespace CEU.Pagamento.Application.Commands
{
    public class ProcessarPagamentoCommand : IRequest<bool>
    {
        public decimal Valor { get; set; }
        public string Metodo { get; set; }

        public ProcessarPagamentoCommand(decimal valor, string metodo)
        {
            Valor = valor;
            Metodo = metodo;
        }
    }
}