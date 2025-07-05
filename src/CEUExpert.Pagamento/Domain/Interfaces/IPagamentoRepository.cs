using System.Threading.Tasks;
using CEU.Pagamento.Domain.Entidades;

namespace CEU.Pagamento.Domain.Interfaces
{
    public interface IPagamentoRepository
    {
        Task Adicionar(Pagamento pagamento);
    }
}