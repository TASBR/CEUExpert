using CEU.Core.Domain.Entities;
using CEU.Core.Domain.Exceptions;

namespace CEU.Aluno.Domain.Entidades
{
    public class Aluno : EntidadeBase
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Aluno(string nome, string email)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new DomainException("Nome inválido");
            if (string.IsNullOrWhiteSpace(email)) throw new DomainException("Email inválido");

            Nome = nome;
            Email = email;
        }
    }
}