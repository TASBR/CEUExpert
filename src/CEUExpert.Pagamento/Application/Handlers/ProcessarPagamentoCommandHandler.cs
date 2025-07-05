using System.Threading;
using System.Threading.Tasks;
using MediatR;
using CEU.Pagamento.Application.Commands;
using CEU.Pagamento.Domain.Entidades;
using CEU.Pagamento.Domain.Interfaces;

namespace CEU.Pagamento.Application.Handlers
{
    public class ProcessarPagamentoCommandHandler : IRequestHandler<ProcessarPagamentoCommand, bool>
    {
        private readonly IPagamentoRepository _pagamentoRepository;

        public ProcessarPagamentoCommandHandler(IPagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }

        public async Task<bool> Handle(ProcessarPagamentoCommand request, CancellationToken cancellationToken)
        {
            var pagamento = new Pagamento(request.Valor, request.Metodo);
            await _pagamentoRepository.Adicionar(pagamento);
            return true;
        }
    }
}