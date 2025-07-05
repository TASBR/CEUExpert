using System.Threading;
using System.Threading.Tasks;
using MediatR;
using CEU.Aluno.Application.Commands;
using CEU.Aluno.Domain.Entidades;
using CEU.Aluno.Domain.Interfaces;

namespace CEU.Aluno.Application.Handlers
{
    public class RegistrarAlunoCommandHandler : IRequestHandler<RegistrarAlunoCommand, bool>
    {
        private readonly IAlunoRepository _alunoRepository;

        public RegistrarAlunoCommandHandler(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task<bool> Handle(RegistrarAlunoCommand request, CancellationToken cancellationToken)
        {
            var aluno = new Aluno(request.Nome, request.Email);
            await _alunoRepository.Adicionar(aluno);
            return true;
        }
    }
}