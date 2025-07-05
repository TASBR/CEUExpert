using System.Threading;
using System.Threading.Tasks;
using MediatR;
using CEU.Conteudo.Application.Commands;
using CEU.Conteudo.Domain.Entidades;
using CEU.Conteudo.Domain.Interfaces;

namespace CEU.Conteudo.Application.Handlers
{
    public class CriarCursoCommandHandler : IRequestHandler<CriarCursoCommand, bool>
    {
        private readonly ICursoRepository _cursoRepository;

        public CriarCursoCommandHandler(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public async Task<bool> Handle(CriarCursoCommand request, CancellationToken cancellationToken)
        {
            var curso = new Curso(request.Nome, request.Descricao);
            await _cursoRepository.Adicionar(curso);
            return true;
        }
    }
}