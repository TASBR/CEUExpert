using System.Threading.Tasks;
using CEU.Aluno.Domain.Entidades;

namespace CEU.Aluno.Domain.Interfaces
{
    public interface IAlunoRepository
    {
        Task Adicionar(Aluno aluno);
    }
}