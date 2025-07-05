using MediatR;

namespace CEU.Aluno.Application.Commands
{
    public class RegistrarAlunoCommand : IRequest<bool>
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public RegistrarAlunoCommand(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}