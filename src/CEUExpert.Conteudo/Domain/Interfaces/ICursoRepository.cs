using System.Threading.Tasks;
using CEU.Conteudo.Domain.Entidades;

namespace CEU.Conteudo.Domain.Interfaces
{
    public interface ICursoRepository
    {
        Task Adicionar(Curso curso);
    }
}